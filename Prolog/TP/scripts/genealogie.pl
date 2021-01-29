homme(jean). % jean est un homme
homme(fabien).
homme(jerome).
homme(emile).
homme(franck).
homme(bruno).
homme(marc).

femme(evelyne). % évelyne est une femme
femme(louise).
femme(julie).
femme(anne).
femme(aurelie).
femme(sophie).
femme(marie).
femme(eve).

pere(emile,jean). % émile est le père de jean
pere(jean,fabien).
pere(fabien,eve).
pere(jean,jerome).
pere(bruno,evelyne).
pere(bruno,franck).
pere(franck,sophie).
pere(franck,aurelie).

mere(louise,jean). % louise est la mere de jean
mere(julie,evelyne).
mere(julie,franck).
mere(evelyne,fabien).
mere(evelyne,jerome).
mere(anne,sophie).
mere(anne,aurelie).
mere(marie,eve).
mere(sophie,marc).

% a) 
% notation prolog exemple : parent(+Parent, -Enfant)
% ça signifie qu'on donne le parent et que prolog nous donne l'enfant

parent(Parent, Enfant):-pere(Parent, Enfant);mere(Parent, Enfant).

% b)
fils(Enfant, Parent):-homme(Enfant), parent(Parent,Enfant).

% c)
gdPere(X,Y):-parent(Z,Y), pere(X,Z).

% d)
ancetre(X, Y):- parent(Z,Y), ancetre(X,Z).
ancetre(X, Y):- parent(X,Y).