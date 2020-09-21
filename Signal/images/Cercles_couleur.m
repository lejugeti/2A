clear all
clc

s =200;
m = s/2;
R=70;
I = [zeros(s);zeros(s)];

centre = [s/2;s/2];
d = 50; %distance des cercles au centre
cr = [0;-d];
cb = d*[-cos(pi/6); sin(pi/6)];
cg = d*[cos(pi/6); sin(pi/6)];

[X,Y] = meshgrid(-s/2:s/2);

a = (X+cr(1,1)).^2 + (Y-cr(2,1)).^2 <= R^2;
b = (X - cb(1,1)).^2 + (Y - cb(2,1)).^2 <= R^2;
c = (X - cg(1,1)).^2 + (Y - cg(2,1)).^2 <= R^2;
imagesc(a);
imagesc(cat(3,c,b,a));
