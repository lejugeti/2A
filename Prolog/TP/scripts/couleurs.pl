couleur(jaune).
couleur(rouge).
couleur(bleu).
couleur(vert).


adj(Z1, Z2):- couleur(Z1), couleur(Z2), Z1\==Z2.

colorier(Z1,Z2,Z3,Z4,Z5,Z6) :-
    adj(Z1,Z6), adj(Z1,Z3), adj(Z1,Z2), adj(Z1,Z5), adj(Z4,Z2), adj(Z3,Z2), adj(Z5,Z2),adj(Z6,Z2),
    adj(Z5, Z6), adj(Z3, Z4), adj(Z3, Z6).