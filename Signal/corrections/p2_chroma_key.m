

clear all
close all

img1=double(imread('./img/people.jpg'));
R1=img1(:,:,1);
G1=img1(:,:,2);
B1=img1(:,:,3);

Y1=0.299*R1+0.587*G1+0.114*B1;
Cb1=0.564*(B1-Y1)+128;

M=double(Cb1>150); %Filtrage du canal Cb pour différencier objet/fond
figure, 
subplot 221
imagesc(uint8(img1))
subplot 222
imagesc(M)

%Fusion avec une deuxième image
img2=double(imread('./img/metro.jpg'));
subplot 223
imagesc(uint8(img2))

R2=img2(:,:,1);
G2=img2(:,:,2);
B2=img2(:,:,3);
R2=R1.*(1-M)+R2.*M;
G2=G1.*(1-M)+G2.*M;
B2=B1.*(1-M)+B2.*M;
img = uint8(cat(3,R2,G2,B2));

subplot 224
imagesc(img)

figure,
subplot 121
imagesc(Cb1); title('Cb1');
subplot 122
imagesc(B1); title('B1');

