%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                                                                                           %%%%%%
%%%%%%%                                                 Intelligence Artificielle Symbolique                                                      %%%%%%
%%%%%%%                                                                                                                                           %%%%%%
%%%%%%%                                               Réalisation d’un jeu en prolog : Quoridor                                                   %%%%%%
%%%%%%%                                                                                                                                           %%%%%%
%%%%%%%                                                                                                                                           %%%%%%
%%%%%%%                 ÉQUIPE : Antoine PARIZE       - Grp 1                          CO8SCIS0 UE Ingéniérie cognitique                          %%%%%%
%%%%%%%                          Juliette ESQUIROL    - Grp 4                                                                                     %%%%%%
%%%%%%%                          Léa GRONDIN          - Grp 4                                                                                     %%%%%%
%%%%%%%                          Thomas ARRACHEQUESNE - Grp 2                                                                                     %%%%%%
%%%%%%%                                                                                                                                           %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

:- dynamic element/4.  % Permet de déplacer les joueurs, et de placer des murs.
:- dynamic joueur/1.   % Joueur est le token permettant de savoir à qui est le tour de jeu
:- encoding(utf8).     % Permet d'afficher les accents

% Clear le champs
clear :- write('\e[2J').

% Leave
quitter :- halt.

% Restart
restart :- retractall(element(_,_,_,_)), retractall(joueur(_)), ['/Users/jesquirol/Downloads/V7.pl'],  start. %Path à modifier

% Afficher règles
regles :- writeln('
\n COMMANDES UTILES :
Arrêter le jeu : “quitter.”
Recommencer à 0 : “restart.”
Consulter les règles : “regles.”

\n BUT DU JEU :
Le premier joueur qui traverse le plateau gagne.
j doit atteindre la ligne 17 et l la ligne 1.

\n REGLES DU JEU :

Choisissez si vous êtes Juju (joueur j) ou Lolo (joueur l).
Lorsque c’est votre tour, vous devez choisir entre 2 possibilités.

Possibilité 1 : se déplacer en tapant “deplacer(sens).”
en remplaçant sens par droite, gauche, haut ou bas selon la direction souhaitée

OU

Possibilité 2 : déposer une barrière (occupe 2 cases) en tapant “poser(X,Y, SENS).”
en remplaçant X par la coordonnée en x de la case de départ où sera posé le mur
en remplaçant Y par la coordonnée en y de la case de départ où sera posé le mur
en remplaçant SENS par hor pour horizontal ou ver pour vertical pour l’orientation du mur

Attention :
Les joueurs débutent avec 10 barrières chacun.
Une barrière occupe deux cases côtes à côtes (ne pas poser de mur en limite de grille).
MUR HORIZONTAL : case de départ = X impair et Y pair
MUR VERTICAL : case de départ = X pair et Y impair
Vous ne devez pas bloquer votre adversaire en l’enfermant.
Si les joueurs se retrouvent face à face, ils se sautent par dessus (chevauchement puis choix de direction).

').



%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                         INITIALISATION                            %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% placer juju et lolo à leur position initiale
element(9, 1, non, j).
element(9, 17, non, l).

% start
start :- afficheGrille, regles.

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                          CASES OCCUPEES                           %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

case(X,Y) :- integer(X), integer(Y), X >= 1, X =< 18, Y >= 1, Y =< 18. % Une case doit appartenir à la grille 18x18

% Une case est occupée s'il y a un joueur
occupee(case(X,Y), C) :- element(X, Y, _, C).

% ou si il y a un mur (un mur occupe deux cases)
occupee(case(X,Y), C) :- X2 is X-2, element(X2, Y, hor, C).
occupee(case(X,Y), C) :- Y2 is Y-2, element(X, Y2, ver, C).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                        Affichage Grille                           %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


afficheTitre :- clear,
                writeln('                            ##########################'),
                writeln('                            ##       QUORIDOR       ##'),
                writeln('                            ##########################\n').


% Pour afficher la grille, on affiche le titre, puis la 1ère case
afficheGrille :- afficheTitre, affiche(case(1,1)),!.

% La 1ère ligne est différente des autres car elle contient le nom de l'axe et les n° des colonnes
afficheFirstLigne :-
  write('                                        X\n'),
  write('\n        1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17\n'),
  write('\n      .....   .....   .....   .....   .....   .....   .....   .....   .....   \n').

% Ce qui suit est un peu imbuvable, voilà l'idée :
% Afin d'avoir un affichage visuelement beau, nous avons dû afficher chaque case différemment en fonction de sa ligne et de sa colonne.

%    Case vide        Joueur              Mur horizontal                Mur Vertical
%     .....           .....                                                    |
%     :   :           : j :                  _____                             |
%     :...:           :...:                                                    |

% Affichage lignes impaires
afficheLigneImpaire(Y) :- write('\n      '), caseLigneImpaire(1,Y).                               % On affiche un alinéa, puis la 1ère case de la ligne
caseLigneImpaire(_,18).
caseLigneImpaire(18,_) :- write('\n').                                                            % Fin de la ligne -> retour à la ligne
caseLigneImpaire(X,Y) :-  R is mod(X,2), R==1, write(':...:'), X1 is X+1, caseLigneImpaire(X1,Y). % Affichage bas des cases
caseLigneImpaire(X,Y) :- element(X, Y, ver,_), X1 is X+1, write(' | '), caseLigneImpaire(X1,Y).   % Affichage des murs verticaux
caseLigneImpaire(X,Y) :- write('   '), X1 is X+1, caseLigneImpaire(X1,Y).                         % Affichage case vide

% Méthode similaire pour les lignes paires
afficheLignePaire(Y) :- write('\n      '), caseLignePaire(1,Y).
caseLignePaire(_,18).
caseLignePaire(18,_) :- write('\n').
caseLignePaire(X,Y) :- R is mod(X,2), R==1, write('.....'), X1 is X+1, caseLignePaire(X1,Y).
caseLignePaire(X,Y) :- Y1 is Y-1, element(X, Y1, ver,_), X1 is X+1, write(' | '), caseLignePaire(X1,Y).
caseLignePaire(X,Y) :- write('   '), X1 is X+1, caseLignePaire(X1,Y).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%     Affichage du mur         %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

afficheCase(case(X,Y)) :- element(X, Y, ver,_), write(' | :').                        % Affichage d'un mur vertical
afficheCase(case(X,Y)) :- Y1 is Y-1, element(X, Y1, ver,_), write(' |  ').            % Affichage du 2ème pan de mur
afficheCase(case(X,Y)) :- Y1 is Y-2, element(X, Y1, ver,_), write(' | :').            % Affichage du 3ème pan de mur
afficheCase(case(X,Y)) :- element(X, Y, hor,_),write('____').                         % Affichage mur horizontal
afficheCase(case(X,Y)) :- X1 is X-1, element(X1, Y, hor,_),write('____').
afficheCase(case(X,Y)) :- X1 is X-2, element(X1, Y, hor,_),write('___ ').

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%    Affichage d'une case      %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

afficheCase(case(X,Y)) :- occupee(case(X,Y), C), write(' '), write(C), write(' :').  % Affichage du nom du joueur dans la case.
afficheCase(case(_,Y)) :- R is mod(Y,2), R==0, write('    ').                        % Affichage d'un espace vide sur les lignes paires
afficheCase(case(_,_)) :- write('   :').                                             % Affichage d'une case vide

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%    Affichage des lignes      %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% 1ère case de la grille
affiche(case(1,1)) :- afficheFirstLigne, numero_ligne(1), afficheCase(case(1,1)), affiche(case(2, 1)).

% Dernière case de la dernière ligne
affiche(case(17,17)) :- afficheCase(case(17,17)), afficheLigneImpaire(17), afficheDecompte(j),afficheDecompte(l),affiche_qui_joue(),affiche_info_barriere.

% Pour la 1ère case de la ligne, on affiche le n°, la case, puis la case suivante
affiche(case(1,Y)) :- R is mod(Y,2), R==1, numero_ligne(Y), afficheCase(case(1,Y)), affiche(case(2, Y)).
affiche(case(1,Y)) :- R is mod(Y,2), R==0,  numero_ligne(Y), write('    '), affiche(case(2, Y)).

% A la fin de la ligne, on passe a la ligne suivante
affiche(case(17,Y)) :- R is mod(Y,2), R==1, afficheCase(case(17,Y)), Y1 is Y+1, afficheLigneImpaire(Y), affiche(case(1, Y1)).
affiche(case(17,Y)) :- R is mod(Y,2), R==0, afficheCase(case(17,Y)), Y1 is Y+1, afficheLignePaire(Y), affiche(case(1, Y1)).

% Pour toutes les autres cases, on les affiche, puis case suivante
affiche(case(X,Y)) :-  afficheCase(case(X,Y)), X1 is X+1, affiche(case(X1, Y)).

% Affichage d'une case vide
affiche(case(X,Y)) :-  write('   '), X1 is X+1, affiche(case(X1, Y)).

% Affichage du nom de l'axe sur la ligne n°9
numero_ligne(9) :- write('Y  9   ').

% Les lignes paires ne contiennent pas de cases dessinées, donc affichage d'un blanc
numero_ligne(N) :- N < 10, R is mod(N,2), R==0, write('   '), write(N), write('   ').

% Celles impaires commences doivent commencer par le début d'une case ':'
numero_ligne(N) :- N < 10, R is mod(N,2), R==1, write('   '), write(N), write('  :').

% Pour les lignes n° 10 à 17, le nombre prend 2 caractères, donc on affiche un espace en moins.
numero_ligne(N) :- R is mod(N,2), R==0, write('   '), write(N), write('  ').
numero_ligne(N) :- R is mod(N,2), R==1, write('   '), write(N), write(' :').

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                      POSER UNE BARRIERE                           %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% X et Y sont les coordonnées de la première case
% V correspond à l'orientation : ver ou hor

poser(X,Y,Direction,Joueur) :-
  mur_bien_place(X,Y,Direction),
  place_disponible_pour_le_mur(X,Y,Direction),
  assert_mur(X,Y,Direction,Joueur),
  afficheGrille.

% Juliette pose des murs de type 'm', et Léa de type 's'

assert_mur(X,Y,Direction,j) :-  decompte(m,N),
                                N > 0,
                                asserta(element(X, Y, Direction, m)).

assert_mur(X,Y,Direction,l) :-  decompte(s,N),
                                N > 0,
                                asserta(element(X, Y, Direction, s)).

% On vérifie qu'il n'y a pas déjà un pan de mur qui bloquerait le nouveau

place_disponible_pour_le_mur(X,Y,ver) :-    not(occupee(case(X,Y),_)),
                                            Y1 is Y+1,
                                            not(occupee(case(X,Y1),_)),
                                            Y2 is Y+2,
                                            not(occupee(case(X,Y2),_)).

place_disponible_pour_le_mur(X,Y,hor) :-    not(occupee(case(X,Y),_)),
                                            X1 is X+1,
                                            not(occupee(case(X1,Y),_)),
                                            X2 is X+2,
                                            not(occupee(case(X2,Y),_)).

% La grille étant de 18x18, les murs peuvent uniquement être posés sur certaines lignes et certaines colonnes :
% Mur horizontal : ligne paire, colonne impaire
% Mur vertical : ligne impaire, colonne paire

affiche_info_barriere :- writeln('\n Mur horizontal : débute sur colonne impaire, ligne paire. EXEMPLE : poser(3,10,hor). \n Mur vertical : débute sur colonne paire, ligne impaire. EXEMPLE : poser(6,3,ver).').

mur_bien_place(X,Y,ver) :-    X >= 1,
                              X =< 17,
                              Y >= 1,
                              Y =< 17,
                              R1 is mod(X, 2),
                              R2 is mod(Y, 2),
                              R1 == 0,
                              R2 == 1.

mur_bien_place(X,Y,hor) :-    X >= 1,
                              X =< 17,
                              Y >= 1,
                              Y =< 17,
                              R1 is mod(X, 2),
                              R2 is mod(Y, 2),
                              R1 == 1,
                              R2 == 0.

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%     Simplification des       %%
%%    commandes à rentrer       %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%     poser(X,Y,Orientation,Joueur)  -->  poser(X,Y,Orientation)
%  La fonction ci-dessous détermine le joueur qui joue, et l'insert automatiquement.

poser(X,Y,Orientation) :-
  joueur(Joueur),
  poser(X,Y,Orientation,Joueur),
  chemin_possible(),
  switch_joueurs().

poser(X,Y,Orientation) :-
    retract(element(X,Y,Orientation,_)),
    afficheGrille,
    write("Poser ce mur bloquerait un des joueurs").

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                NOMBRE DE MURS RESTANTS A POSER                    %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% On recherche le nombre k de murs posés par chaque joueur, un joueur en pose 10 maximum, 10 - k nous donne le nombre restant.
decompte(LETTRE,N) :- findall(_,element(_,_,_,LETTRE),L), length(L,N1), N is 10-N1 .

afficheDecompte(j) :- decompte(m,N), write("\n nombre de barrières restantes à j : "),write(N).
afficheDecompte(l) :- decompte(s,N), write("\n nombre de barrières restantes à l: "),write(N).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                         DEPLACEMENTS                              %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

deplacer(C, Direction) :-
                        element(X, Y, _, C),                      % Position du joueur
                        prochaine_case(X,Y,Direction,X1,Y1),      % Prochaine case - si elle existe
                        not(mur_bloquant(case(X,Y),Direction)),   % Pas de mur qui bloque
                        retract(element(X, Y, non, C)),           % On déplace le joueur
                        asserta(element(X1, Y1, non, C)),
                        switch_joueurs,                           % C'est au tour du prochain joueur de jouer, et on actualise la map
                        sauter_pion(case(X1,Y1),C,Direction).     % On regarde si on a atteri sur un joueur, si oui, on fait ce qu'il y a ci-dessous.

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%        Sauter un pion        %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% Si on arrive sur une case contenant un joueur on essaye de passer de l'autre côté
sauter_pion(case(X,Y),C,Direction) :- element(X,Y,non,Joueur),
                                      Joueur \== C,
                                      switch_joueurs,
                                      deplacer(C, Direction),
                                      afficheGrille.

% S'il y'a un mur après le joueur, c'est toujours le même joueur qui rejoue (il est superposé sur son adversaire et doit choisir une direction)
sauter_pion(case(X,Y),C,_) :- element(X,Y,non,Joueur),
                              Joueur \== C,
                              write("\n \n Le joueur "),
                              write(C),
                              write(" chevauche actuellement un autre joueur.").

sauter_pion(_,_,_).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%      Un mur bloque  ?        %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% Vérifie si un mur bloque le déplacement dans une des directions.

mur_bloquant(case(X,Y),droite) :-     X1 is X+1,
                                      occupee(case(X1, Y), _).
mur_bloquant(case(X,Y),gauche) :-     X1 is X-1,
                                      occupee(case(X1, Y), _).
mur_bloquant(case(X,Y),haut) :-       Y1 is Y-1,
                                      occupee(case(X, Y1), _).
mur_bloquant(case(X,Y),bas) :-        Y1 is Y+1,
                                      occupee(case(X, Y1), _).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%      La prochaine case       %%
%%   appartient à la grille ?   %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

prochaine_case(X1,Y,droite,X2,Y) :-  X2 is X1+2,
                                     case(X2,Y).

prochaine_case(X1,Y,gauche,X2,Y) :-  X2 is X1-2,
                                     case(X2,Y).

prochaine_case(X,Y1,haut,X,Y2) :-   Y2 is Y1-2,
                                    case(X,Y2).

prochaine_case(X,Y1,bas,X,Y2) :-    Y2 is Y1+2,
                                    case(X,Y2).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%      Simplification          %%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% Comme pour poser un mur, on simplie le déplacement en déterminant le joueur qui est en train de jouer.

deplacer(Direction) :- joueur(Joueur),
                       deplacer(Joueur,Direction),
                       victoire().

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                         À QUI DE JOUER ?                          %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% juju commence la partie
joueur(j).

% Changement du tour en fonction du joueur actuel
switch_joueurs :-   joueur(j),
                    retract(joueur(j)),
                    asserta(joueur(l)),
                    afficheGrille, !. % Mettre un cran d'arrêt sinon le fait ayant été changé juste avant, on entre dans le switch_joueurs suivant

switch_joueurs :-   joueur(l),
                    retract(joueur(l)),
                    asserta(joueur(j)),
                    afficheGrille, !.

affiche_qui_joue() :- joueur(Joueur),
                      write("\n C'est au tour du joueur "),
                      write(Joueur),
                      write(" de jouer. \n").

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%                         CHEMIN LIBRE                              %%%%%%
%%%%%%%                                                                   %%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% Voisin renvoit les cases accessibles autour d'une case donnée
voisin(case(X1,Y),case(X2,Y)) :- X2 is X1 + 2, X2 =< 17, not(mur_bloquant(case(X1,Y),droite)).
voisin(case(X1,Y),case(X2,Y)) :- X2 is X1 - 2, X2 >= 1, not(mur_bloquant(case(X1,Y),gauche)).
voisin(case(X,Y1),case(X,Y2)) :- Y2 is Y1 - 2, Y2 >= 1, not(mur_bloquant(case(X,Y1),haut)).
voisin(case(X,Y1),case(X,Y2)) :- Y2 is Y1 + 2, Y2 =< 17, not(mur_bloquant(case(X,Y1),bas)).

chemin(Depart, Arrivee, Chemin):-
    chemin(Depart, Arrivee, [Depart], Chemin). % ne sert qu'à ajouter le troisième argument
% c'est le chemin déjà parcouru, donc la ville de départ au début

% si je suis à la ville d'arrivée, c'est que le travail est fini :
% le chemin déjà parcouru est alors le chemin recherché
chemin(Arrivee, Arrivee, Chemin, Chemin):-!.

chemin(Depart, Arrivee,CheminParcouru, CheminComplet):-
    findall(Case, voisin(Depart, Case), ListeCasesAccessibles),  % construit la liste des voisines immédiates
    member(ProchaineEtape, ListeCasesAccessibles), % choisit une étape dans cette liste
    not(member(ProchaineEtape, CheminParcouru)), % je ne reviens pas sur mes pas
    append( CheminParcouru,[ProchaineEtape], NouveauChemin), % j'ajoute l'étape au parcours
    chemin(ProchaineEtape, Arrivee, NouveauChemin, CheminComplet). % récursivement jusqu'à l'arrivée

% On vérifie qu'aucun des 2 joueurs ne soient bloqués - avec Lolo pouvant atteindre le haut de la grille, et Juju le bas.
chemin_possible() :-
  element(X1,Y1,non,j),
  element(X2,Y2,non,l),
  chemin(case(X1,Y1),case(XF,17),_),
  chemin(case(X2,Y2),case(XF,1),_),
  XF >= 1,
  XF =< 17.


  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  %%%%%%%                                                                   %%%%%%
  %%%%%%%                         VICTOIRE                                  %%%%%%
  %%%%%%%                                                                   %%%%%%
  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


%%%%%%%%%%% Victoire de Juju arrivant en bas du plateau
victoire() :- element(_,17,non,j),
              write("Victoire de Juliette").

%%%%%%%%%%% Victoire de Lolo arrivant en haut du plateau
victoire() :- element(_,1,non,l),
              write("Victoire de Léa").
