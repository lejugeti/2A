route(s,a). % une route relie la ville s a la ville a
route(s,d).
route(a,b).
route(a,d).
route(b,c).
route(b,e).
route(d,e).

voisines(X,Y):-route(X,Y).
voisines(X,Y):-route(Y,X).

% requête pour obtenir les villes permettant de rallier la ville b en 
% 1 étape
route(s,Etape),route(Etape,b). 