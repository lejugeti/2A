clear all
clc

img = imread('../images/pool.tif');

img2 = rgb2ycbcr(img);
Y = img2(:,:,1);
CbCompressed = imresize(img2(:,:,2), 0.5);
CrCompressed = imresize(img2(:,:,3), 0.5);

%Pour le deuxième appel de imresize on spécifie la taille des matrices
%sinon on a une erreur d'arrondi et ça casse les couilles
CbResized = imresize(CbCompressed, [383 510]); 
CrResized = imresize(CrCompressed, [383 510]);

imgNew = cat(3, img2(:,:,1), CbResized, CrResized);
imgNew = ycbcr2rgb(imgNew);

figure, subplot(1,2,1)
imshow(img);
subplot(1,2,2)
imshow(imgNew);