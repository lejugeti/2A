[a, palette] = imread('lena.bmp');

%au d�but, il est important de regarder la dimension de l'image, si elle
%est cod�e en vraies ou fausses couleurs car c'est important pour le ttt
%la colormap permet de changer de palette de couleur (fausses couleurs)
%figure,imshow(a,colormap(jet));
%figure,imshow(a,palette);

%vectorisation d'une matrice
a_vect = a(:);
b = max(a_vect);

%cr�er un vecteur (d�but:step:fin)
v = (1:2:10);

%�a permet de sous-�chantillonner car on peut prendre juste une portion des pixels d'une image
a_ech = a(1:4:end, 1:4:end);
%figure,imshow(a_ech);

% multiplication terme � terme avec l'op�rateur .
a_carre = a.*a;
figure,imshow(a_carre);

%% afficher les diff�rentes images de la matrice challenges.mat
c = load('challenge.mat');
bab = c.A;
bab_vect = bab(:);
bab = bab/max(bab_vect);
imagesc(bab);

%% 
form = c.B;

figure,imagesc(form);
axis image;

%% on a des probl�mes d'intensit� pour les contrastes de couleur
%On veut utiliser plus de couleurs pour le bleu et moins pour le jaune en
%fait car on en a bien moins besoin

C = c.C;
C_vect = C(:);
figure,imagesc(C, [60 230]);

%% 

D = c.D;
figure,imagesc(D);
colormap(summer);

%% ici on doit cr�er notre prore palette vu qu'on a des intensit�s discr�tes
map = [255,0,255;
    255,255,0;
    148,0,211;
    0,255,255;
    13,232,50;
    255,90,255;
    255,165,43;];

map = map/255;
E = c.E;
figure,imagesc(E);
colormap(map);