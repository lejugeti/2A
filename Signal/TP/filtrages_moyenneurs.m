%% filtrage moyenneur barbara
clear all
clc

k = 2;
I1 = imread('../images/barbara_awgn_noise.png');
I2 = imread('../images/cameraman_sp_noise.png');

fVert = (1/(2*k+1)).* ones(2*k+1, 1);
fHoriz = (1/(2*k+1)).* ones(1, 2*k+1);
f = fVert * fHoriz;

res1 = conv2(I1,f);
res2 = conv2(I2,f);
figure,
imagesc(res1);
colormap('gray');

figure,
imagesc(res2);
colormap('gray');


%% filtrage gaussiens

sigma = 2;
size = 2;
fGauss = fspecial('gaussian', size, sigma);

res1G = conv2(I1, fGauss);
res2G = conv2(I2, fGauss);

figure,
imagesc(res1G);
colormap('gray');

figure,
imagesc(res2G);
colormap('gray');

%% filtrage m�dian

clc

v = 2; % + v grand + l'image est de mauvaise qualit� du coup
SizeI = size(I2);
h = SizeI(1);
w = SizeI(2);
I_Filtre = zeros(h, w);

%ici on fait une convolution � la main plus ou moins
for i=1:h-v
    for j=1:w-v
        window = I2(i:i+v, j:j+v);
        I_Filtre(i+v/2, j+v/2) = median(window(:)); 
    end
end

figure,
imagesc(I_Filtre);
colormap('gray');

%% filtrage fr�quentiel
% l'image est bruit�e avec des composantes fr�quentielles tr�s
% particuli�res donc on essaye de les �liminer avec un filtre particulier

clc

I_pise = imread('../images/pise_ext.bmp');

fft_I = log10(abs(fft2(I_pise)));
[h,w] = size(I_pise);
fx=linspace(-0.5,0.5,w);
fy=linspace(-0.5, 0.5,h);

%figure,
%imagesc(I_pise);
%colormap('gray');

%figure,
%imagesc(fx, fy,fftshift(fft_I));

% ici on cr�e un filtre fr�quentiel � partir de diff�rents signaux, qui ont
% pour but d'annuler le bruit fr�quentiel de l'image. On ne manipule que
% les signaux dans le domaine temporel ici, mais c'est leur composante
% fr�quentielle qui permet d'annuler le bruit gr�ce � une convolution.
% En gros on a des fr�quences de forte intensit� qu'on ne veut pas donc on
% va venir les annuler, elles et seulement elles.
sigma=2.0;
fx=0.25;
fy=-0.25;
t=ceil(3*sigma);
[X,Y]=meshgrid(-t:t);

%Gaussienne � Gaussienne (F)
H4=exp(-(X.^2+Y.^2)/(2*sigma^2));
H4=H4./sum(H4(:));

%Cosinus � Double Dirac (fx,fy) (F)
H4=2*cos(2*pi*(X*fx+Y*fy)).*H4;

%Inversion � Inversion (F)
H4=-H4;

%Dirac � Constante (1) (F)
H4(t+1,t+1)=H4(t+1,t+1)+1;
figure, freqz2(H4)
E = conv2(I_pise ,H4,'same');
figure, imshow(uint8(E));
IfE = fftshift(log10(abs(fft2(E))));
figure, imagesc(fx,fy,IfE)

figure, surf(H4);