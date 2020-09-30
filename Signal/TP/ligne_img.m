clear all
clc

img = imread('cameraman.tif');
imshow(img);


[x, y] = ginput(2);
x = sort(x);
y =sort(y);
y1 = round(y(1));
y2 = round(y(2));
x1 = round(x(1));
x2 = round(x(2));

if(abs(x(1)-x(2)) > abs(y(1)-y(2)))
    a = img(y1, x1:x2);
else
    a = img(y1:y2, x1);
end


plot(a);

%% avec une image couleur

clear all
clc

img2 = imread('../images/background.jpg');
imagesc(img2);

[x, y] = ginput(2);
x = sort(x);
y =sort(y);
y1 = round(y(1));
y2 = round(y(2));
x1 = round(x(1));
x2 = round(x(2));

if(abs(x(1)-x(2)) > abs(y(1)-y(2)))
    a = img2(y1, x1:x2, 1:3);
else
    a = img2(y1:y2, x1, 1:3);
end

figure;
hold on
plot(a(:,:,1), 'r');
plot(a(:,:,2), 'g');
plot(a(:,:,3), 'b');
hold off