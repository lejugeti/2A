clear all
close all
clc 

A=imread('../images/building.jpg');

figure, image(A)
colormap(gray(256))
[h,w]=size(A);

B=log10(abs(fft2(A))); %fft de l'image

fx=linspace(0,1-1/w,w);
fy=linspace(0,1-1/h,h);
figure, imagesc(fx,fy,B);
colormap(jet(256))

fx=linspace(-0.5,0.5-1/w,w);
fy=linspace(-0.5,0.5-1/h,h);
figure
imagesc(fx,fy,fftshift(B)); %affichage fft shiftée
colormap(jet(256))
