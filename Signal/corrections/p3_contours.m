
clear all
close all
clc

img = imread('../img/home.jpg');
img_ycbcr = rgb2ycbcr(uint8(img));

P = -10:0.1:10;
[X,Y] = meshgrid(P,P);
% 2) On retrouve l’expression des dérivées en x et y de g(x,y) pour leur fournir les cartes du meshgrid et obtenir deux filtres détecteurs de contours Gx Gy :
sig = 0.05;
Gx = -X/(2*pi*sig^4).*exp(-(X.^2+Y.^2)/(2*sig^2));
Gy = -Y/(2*pi*sig^4).*exp(-(X.^2+Y.^2)/(2*sig^2));
figure, surf(Gx); title('Filtre Gx'); shading interp;
% 3) Calculer la norme des deux réponses pour obtenir une détection de contours :
Ix = conv2(img_ycbcr(:,:,1),Gx,'same');
Iy = conv2(img_ycbcr(:,:,1),Gy,'same');

figure,
imagesc(Ix); title('Détection de contours en X');
figure, imagesc(Iy); title('Détection de contours en Y');

%Norme et normalisation entre 0 et 1
delta_I = sqrt(Ix.^2 + Iy.^2);
delta_I = delta_I / max(delta_I(:));
figure, subplot 121; imagesc(delta_I);
title('Carte de contours (intensité entre 0 et 1)');

%Seuillage binaire
delta_I_th = delta_I>0.35;
subplot 122; imagesc(delta_I_th);
title('Carte de contours binaire');


%% Application pencil sketch

close all

%On récupère la carte de contours soft (entre 0 et 1)
C = delta_I; 

alpha = 36;
beta = 16;
img_ycbcr(:,:,1) = (255-alpha)*(1-C) + beta;
img_esquisse = ycbcr2rgb(img_ycbcr);

figure,
imagesc(img_esquisse);
title('Résultat pencil skecth (Carte soft Gaussienne)');

%% Comparaison avec le résultat de edge

%On récupère la carte de contours soft (entre 0 et 1)
C = edge(img_ycbcr(:,:,1)); 
figure, imagesc(C); title('Carte binaire de edge');

alpha = 36;
beta = 16;
img_ycbcr(:,:,1) = (255-alpha)*(1-C) + beta;
img_esquisse = ycbcr2rgb(img_ycbcr);

figure,
imagesc(img_esquisse);
title('Résultat pencil skecth (Carte binaire de edge)');
