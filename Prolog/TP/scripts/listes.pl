liste([_|Q]):-
    liste(Q).


premier(E, [E|_]).

dernier(E, [_|Q]):- dernier(E, Q).
dernier(E, [E]).

longueur(0, []).
longueur(N, [_|Q]):-
    longueur(N1, Q),
    N is N1+1.
    
dans(X, [T|_]):- X == T.
dans(X, [_|Q]):- dans(X, Q).

cut(T, Q, [T|Q]). % sert à couper une liste mais aussi à ajouter un autre élément

