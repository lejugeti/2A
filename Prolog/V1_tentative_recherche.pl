:- dynamic element/2.  %Sinon impossible de déplacer les éléments
:- dynamic element/4.  %Sinon impossible de déplacer les éléments
:- encoding(utf8). %Sinon accents pas affichés

clear :- write('\e[2J').

quitter :- halt.

afficheRegles :- writeln('les règles sont blabla\n').

afficheTitre :- clear,
                writeln('###########################'),
                writeln('##        QUORIDOR       ##'),
                writeln('###########################\n').

%%%%%%%%%%%%%%%% ELEMENTS %%%%%%%%%%%%%%%%

element(3, 1, non, j).
element(3, 5, non, l).
element(3, 4, hor, m). % Les murs horizontaux sont définis par une position x impaire et y paire
element(2, 1, ver, s). % Les murs verticaux sont définis par une position x paire et y impaire

orientation(hor).
orientation(ver).
orientation(non).

type(j).  %pour juliette (joueur)
type(l).  %pour léa (joueur)
type(m).  %pour mur (séparation posée par juliette)
type(s).  %pour séparation (séparation posée par léa)

%%%%%%%%%%%%%%%% CASES OCCUPEES %%%%%%%%%%%%%%%%

case(X,Y) :- integer(X), integer(Y), X >= 1, X =< 18, Y >= 1, Y =< 18.
occupee(case(X,Y), C) :- element(X, Y, _, C).
occupee(case(X,Y), C) :- X1 is X, element(X1, Y, hor, C).
occupee(case(X,Y), C) :- X2 is X-1, element(X2, Y, hor, C).
occupee(case(X,Y), C) :- X2 is X-2, element(X2, Y, hor, C).
occupee(case(X,Y), C) :- Y1 is Y, element(X, Y1, ver, C).
occupee(case(X,Y), C) :- Y2 is Y-1, element(X, Y2, ver, C).
occupee(case(X,Y), C) :- Y2 is Y-2, element(X, Y2, ver, C).

%%%%%%%%%%%%%%%% AFFICHAGE GRILLE %%%%%%%%%%%%%%%%

afficheGrille :- afficheTitre, affiche(case(1,1)), !.

afficheLigne :- write('\n-------------------------------------------------------------------------\n').

afficheCase(case(X,Y)) :- occupee(case(X,Y), C), write(' '), write(C), write(' |').
afficheCase(case(_,_)) :- write('   |').

affiche(case(1,1)) :- afficheLigne, write('|'), afficheCase(case(1,1)), affiche(case(2,1)).
affiche(case(18,18)) :- afficheCase(case(18,18)), afficheLigne, afficheDecompte(j),afficheDecompte(l).

affiche(case(1,Y)) :- write('|'), afficheCase(case(1,Y)), affiche(case(2, Y)).
affiche(case(18,Y)) :- afficheCase(case(18,Y)), Y1 is Y+1, afficheLigne, affiche(case(1, Y1)).
affiche(case(X,Y)) :- afficheCase(case(X,Y)), X1 is X+1, affiche(case(X1, Y)).


%%%%%%%%%%%%%%%% POSER BARRIERE %%%%%%%%%%%%%%%%
%W correspond au joueur qui pose (soit j soit l pour juliette ou léa)
%X et Y sont les coordonnées de la première case
%V correspond à l'orientation : ver ou hor

%Ajout pour les barrières horizontales
ajoutOccupee(X, Y, hor) :-
    X1 is X+1,
    X2 is X+2,
    asserta(caseOccupee(X, Y)),
    asserta(caseOccupee(X1, Y)),
    asserta(caseOccupee(X2, Y)).

%Ajout pour les barrières verticales
ajoutOccupee(X, Y, ver) :-
    Y1 is Y+1,
    Y2 is Y+2,
    asserta(caseOccupee(X, Y)),
    asserta(caseOccupee(X, Y1)),
    asserta(caseOccupee(X, Y2)).

poser(X,Y,V,W) :- asserta(element(X, Y, V, W)),
                    ajoutOccupee(X, Y, V),
                    afficheGrille,!.

%%%%%%%%%%%%%%%% RECHERCHE CHEMIN %%%%%%%%%%%%%%%%

% règles pour obtenir les noeuds même en bordures
ajoutOuvertDroite(18, _).
ajoutOuvertGauche(1, _).
ajoutOuvertBas(_, 18).
ajoutOuvertHaut(_, 1).

% clauses pour obtenir les noeuds même en bordures
ajoutOuvertDroite(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    ajoutOuvertDroite(X, Y).

ajoutOuvertGauche(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    ajoutOuvertGauche(X, Y).

ajoutOuvertBas(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    ajoutOuvertBas(X, Y).

ajoutOuvertHaut(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    ajoutOuvertHaut(X, Y).

% clauses pour obtenir les noeuds même si case occupée
ajoutOuvertDroite(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    X1 is X+1,
    caseOccupee(X1, Y).

ajoutOuvertGauche(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    X1 is X-1,
    caseOccupee(X1, Y).

ajoutOuvertBas(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    Y1 is Y+1,
    caseOccupee(X, Y1).

ajoutOuvertHaut(X, Y, _, Ouverts, _, NewOuverts):-
    NewOuverts = Ouverts,
    Y1 is Y-1,
    caseOccupee(X, Y1).

% clauses pour obtenir les noeuds normalement
ajoutOuvertDroite(X, Y, Joueur, Ouverts, Fermes, NewOuverts):-
    X1 is X+1,
    X1 =< 18, X1 >= 1, Y =< 18, Y >= 1,
    not(caseOccupee(X1,Y)),
    not(memberchk(element(X1,Y,_,Joueur), Fermes)),
    not(memberchk(element(X1,Y,_,Joueur), Ouverts)),
    NewOuverts = [element(X1,Y,_,Joueur)|Ouverts].

ajoutOuvertGauche(X, Y, Joueur, Ouverts, Fermes, NewOuverts):-
    X1 is X-1,
    Y1 = Y,
    X1 =< 18, X1 >= 1, Y1 =< 18, Y1 >= 1,
    not(caseOccupee(X1,Y1)),
    not(memberchk(element(X1,Y1,_,Joueur), Fermes)),
    not(memberchk(element(X1,Y1,_,Joueur), Ouverts)),
    NewOuverts = [element(X1,Y1,_,Joueur)|Ouverts].

ajoutOuvertBas(X, Y, Joueur, Ouverts, Fermes, NewOuverts):-
    Y1 is Y+1,
    X =< 18, X >= 1, Y1 =< 18, Y1 >= 1,
    not(caseOccupee(X,Y1)),
    not(memberchk(element(X,Y1,_,Joueur), Fermes)),
    not(memberchk(element(X,Y1,_,Joueur), Ouverts)),
    NewOuverts = [element(X,Y1,_,Joueur)|Ouverts].

ajoutOuvertHaut(X, Y, Joueur, Ouverts, Fermes, NewOuverts):-
    Y1 is Y-1,
    X =< 18, X >= 1, Y1 =< 18, Y1 >= 1,
    not(caseOccupee(X,Y1)),
    not(memberchk(element(X,Y1,_,Joueur), Fermes)),
    not(memberchk(element(X,Y1,_,Joueur), Ouverts)),
    NewOuverts = [element(X,Y1,_,Joueur)|Ouverts].

% ajout de tous les noeuds possibles environnants
ajoutOuverts.

ajoutOuverts(element(X,Y,_,Joueur), Ouverts, Fermes, NewOuverts) :-
    ajoutOuvertDroite(X, Y, Joueur, Ouverts, Fermes, NewOuverts1),
    ajoutOuvertGauche(X, Y, Joueur, NewOuverts1, Fermes, NewOuverts2),
    ajoutOuvertBas(X, Y, Joueur, NewOuverts2, Fermes, NewOuverts3),
    ajoutOuvertHaut(X, Y, Joueur, NewOuverts3, Fermes, NewOuverts4),
    NewOuverts = NewOuverts4.

ajoutOuverts(_,_,_,_) :- ajoutOuverts.


recherche(element(_,18,_,j)).
recherche(element(_,1,_,l)).

recherche(element(X,Y,_,Joueur), _, _) :-
    recherche(element(X,Y,_,Joueur)).

recherche(element(X,Y,_,Joueur), Ouverts, Fermes):-
    ajoutOuverts(element(X, Y, _, Joueur), Ouverts, Fermes, [NoeudCourant|ResteOuvert]),
    recherche(NoeudCourant, ResteOuvert, [element(X, Y, _, Joueur)|Fermes]).


%%%%%%%%%%%%%%%% CODE DE TEST %%%%%%%%%%%%%%%%%
testAjoutOuverts(element(X,Y,_,Joueur), Ouverts, Fermes, ProchainNoeud, ResteOuvert):-
    ajoutOuverts(element(X, Y, _, Joueur), Ouverts, Fermes, [ProchainNoeud|ResteOuvert]).

test(element(X,Y,_,Joueur), Ouverts, Fermes, NewFermes):-
    ajoutOuverts(element(X, Y, _, Joueur), Ouverts, Fermes, [NoeudCourant|ResteOuvert]),
    NewFermes = [NoeudCourant|Fermes].

%%%%%%%%%%%%%%%% DEPLACEMENTS %%%%%%%%%%%%%%%%

sens(gauche).
sens(droite).
sens(haut).
sens(bas).

decompte(LETTRE,N) :- findall(_,element(_,_,_,LETTRE),L), length(L,N2), N is 10-N2 .

afficheDecompte(j) :- decompte(m,N), write("Il reste au joueur j : "),write(N),write(" barrières à placer. ").
afficheDecompte(l) :- decompte(s,N), write("Il reste au joueur l : "),write(N),write(" barrières à placer. ").
%afficheDecompte(LETTRE) :- decompte(LETTRE,N), write("Il reste au joueur "), write(LETTRE), write(","),write(N),write(" barrières à placer").

deplacer(C, gauche) :-  element(X, Y, non, C),
                        X1 is X-1,
                        X2 is X-2,
                        case(X1, Y),
                        not(occupee(case(X1, Y), _)),
                        retract(element(X, Y, non, C)),
                        asserta(element(X2, Y, non, C)),
                        afficheGrille,!.

deplacer(C, droite) :-  element(X, Y, non, C),
                        X1 is X+1,
                        X2 is X+2,
                        case(X1, Y),
                        not(occupee(case(X1, Y), _)),
                        retract(element(X, Y, non, C)),
                        asserta(element(X2, Y, non, C)),
                        afficheGrille,!.

deplacer(C, haut) :-    element(X, Y, non, C),
                        Y1 is Y-1,
                        Y2 is Y-2,
                        case(X, Y1),
                        not(occupee(case(X, Y1), _)),
                        retract(element(X, Y, non, C)),
                        asserta(element(X, Y2, non, C)),
                        afficheGrille,!.

deplacer(C, bas) :-     element(X, Y, non, C),
                        Y1 is Y+1,
                        Y2 is Y+2,
                        case(X, Y1),
                        not(occupee(case(X, Y1), _)),
                        retract(element(X, Y, non, C)),
                        asserta(element(X, Y2, non, C)),
                        afficheGrille.



%%%%%%%%%%%%%%%% VICTOIRE %%%%%%%%%%%%%%%%

%victoire :- write('Bravo !'),!.

%%%%%%%%%%% Victoire de Juliette sortie du plateau en bas
%deplacer(j, bas) :-  element(_, 18,_, 1, j),
%                        victoire.

%%%%%%%%%%% Victoire de Léa sortie du plateau en haut
%deplacer(l, haut) :-  element(_, 1,_, 1, l),
%                        victoire.
:-poser(1,11,hor,m).
:-poser(4,11,hor,m).
:-poser(7,11,hor,m).
:-poser(10,11,hor,m).
:-poser(13,11,hor,m).
%:-poser(16,11,hor,m).
