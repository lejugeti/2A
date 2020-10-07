clear all
close all
clc

img = imread('../images/home.jpg');
img_ycbcr = rgb2ycbcr(uint8(img));

C = edge(img_ycbcr(:,:,1)); 
%edge veut du h*w, pas du h*w*3, donc on lui donne par exemple le canal de
%luminance Y
figure, imagesc(C); title('Carte de contours');

alpha = 36;
beta = 16;
img_ycbcr(:,:,1) = (255-alpha)*(1-C) + beta;
img_esquisse = ycbcr2rgb(img_ycbcr);

figure,
imagesc(img_esquisse);
title('Résultat pencil skecth.png');
