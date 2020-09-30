%% on essaye de délimiter les contours d'une image pour les plot 
clear all
clc

img = imread('../images/home.jpg');
img = rgb2ycbcr(img);

e = edge(img(:,:,1));
a = 2;
b = 3;
Y = (255 - a) * (1 - e) + b;

newImg = cat(3, Y, img(:,:,2), img(:,:,3));
newImg = ycbcr2rgb(newImg);
imshow(newImg);