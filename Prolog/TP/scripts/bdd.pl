vol(1, bdx, cdg, 1155, 1305,123).
vol(2, lse, cdg, 1155, 1405,135).
vol(3, bdx, ory, 1155, 1315,83).
vol(4, bdx, cdg, 1655, 1805,123).
vol(5, cdg, bdx, 1055, 1805,12).

% vol(Nb, bdx, Arrivee, HDepart, HArrivee, NbPassager).

% a)
vol(Nb, bdx, _, _, _, _).

% b)
vol(Id, _, bdx, _,_,_).

% c)
vol(Id, _, _, HD,_,_), HD < 1200.

% d)
vol(Id, _, _, _, HA,_), HA >= 1400.

% e)
vol(Id, _, _, _, HA, Nb), HA < 1700, Nb > 100.

% f)
% ce qui est intéressant ici cest quon utilise la meme variable
% HD dans les deux clauses plutôt que de refaire un test avec
% HD1 == HD2 par exemple
% On gagne beaucoup en efficacité grâce à ça car le logiciel ne recupere
% pas deux fois l ensemble de toutes les données

% Si on a des calculs on va utiliser =\=. Si on utilise \== ça compare le lexicographique 
% et pas la différence numérique
vol(N1, VD1, _, HD, _, _), vol(N2, VD2, _, HD, _, _), HD1\==HD2.

% e)
% On utilise is pour faire un calcul sinon ça ne marche pas
vol(Id, _, _, HD, HA, _), Duree is HA-HD, Duree >= 0200.
