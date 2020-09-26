clear all
clc

s =200;
m = s/2;
R=70;

d = 50; %distance des cercles au centre
cr = [0;-d]; %centre rouge
cb = d*[-cos(pi/6); sin(pi/6)]; %centre bleu
cg = d*[cos(pi/6); sin(pi/6)]; %centre vert

[X,Y] = meshgrid(-s/2:s/2);

a = (X - cr(1,1)).^2 + (Y - cr(2,1)).^2 <= R^2;
b = (X - cb(1,1)).^2 + (Y - cb(2,1)).^2 <= R^2;
c = (X - cg(1,1)).^2 + (Y - cg(2,1)).^2 <= R^2;
imagesc(a);
imagesc(cat(3,c,b,a));
