facto(0, 1).
facto(N, R) :-
    N > 0,
    N1 is N - 1,
    facto(N1, R1),
    R is N*R1.

facto2(N,R) :- facto2(N, 0, 1, R).

facto2(N, RA, ACC, R) :-
    RA < N,
    PR is RA+1,
    NACC is ACC*PR,
    facto2(N, PR, NACC, R).

facto2(N, N, ACC, ACC).