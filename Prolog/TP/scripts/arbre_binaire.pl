unArbre(bt(  bt([],12,[]), 4, bt(bt(bt(bt([],12,[]),3,[]),4, bt([],5,[])),8,[]) )).

arbreBinaire(bt(SAG, _, SAD)):-
    arbreBinaire(SAG),
    arbreBinaire(SAD).

arbreBinaire([]).

dansArbre(E, bt(_, E, _)).
dansArbre(E, bt(SAG, E, _)):-
    dansArbre(E, SAG).

dansArbre(E, bt(_, E, SAD)):-
    dansArbre(E, SAD).



profondeur(P,  bt(SAG, _, SAD)):-
    profondeur(PAG, SAG),
    profondeur(PAD, SAD),
    max(PAD, PAG, PMAX),
    P is PMAX + 1.

prolog(0, []).
max(X,Y,X):- X>Y, !.
max(_,Y,Y).