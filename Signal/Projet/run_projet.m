clear all 
clc

img = imread('phone.jpg');
R1 = img(:,:,1);
G1 = img(:,:,2);
B1 = img(:,:,3);
%imshow(img);

%%
img2 = rgb2ycbcr(img);
Y = img2(:,:,1);
Cb = img2(:,:,2);
Cr = img2(:,:,3);

keyBleu = uint8(img2(:,:,2) > 135);

R1 = R1 .* (1-keyBleu);
G1 = G1 .* (1-keyBleu);
B1 = B1 .* (1-keyBleu);
newImg = cat(3, R1, G1, B1);

%imshow(newImg);