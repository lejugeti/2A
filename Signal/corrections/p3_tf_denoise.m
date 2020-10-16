clear all, close all, clc

A = imread('../images/pise_ext.bmp');

sigma=2.0;
fx=0.25;
fy=-0.25;
t=ceil(3*sigma);
[X,Y]=meshgrid(-t:t);

%Gaussienne – Gaussienne (F)
H4_1 = exp(-(X.^2+Y.^2)/(2*sigma^2));
H4_1 = H4_1/sum(H4_1(:));
%Cosinus – Double Dirac (fx,fy) (F)
H4_2 = 2*cos(2*pi*(X*fx+Y*fy)).*H4_1;
%Inversion – Inversion (F)
H4_3 = -H4_2;
%Dirac – Constante (1) (F)
H4_4 = H4_3;
H4_4(t+1,t+1) = H4_4(t+1,t+1)+1;

E = conv2(A,H4_4,'same');
figure, imshow(uint8(E));
IfE = fftshift(log10(abs(fft2(E))));
figure, imagesc(fx,fy,IfE)

%% Représentation des filtres

figure, 
subplot 221
freqz2(H4_1)
subplot 222
freqz2(H4_2)
subplot 223
freqz2(H4_3)
subplot 224
freqz2(H4_4)
title('Filtre fréquentiel (coupe bande)');

figure, 
subplot 221
surf(H4_1)
subplot 222
surf(H4_2)
subplot 223
surf(H4_3)
subplot 224
surf(H4_4)
title('Filtre Spatial');
