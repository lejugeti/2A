I = double(imread('../img/barbara_awgn_noise.png'));
[h,w,z] = size(I);

figure, 
imagesc(I)
 
%Paramètres (à faire varier)
v_size = 4;  sigma_s = 1; sigma_c = 4;
 
img_bf = double(I*0);
%Parcours de tous les pixels de l'image
for i=1:h
    i
    for j=1:w
        sum_w = 0;
         %Sélection d'une fenêtre (2*v_size+1)x(2*v_size+1) ajustée au bord
         for ii=max(i-v_size,1):min(i+v_size,h)
             for jj=max(j-v_size,1):min(j+v_size,w)
                  %A compléter
                  w_s = exp(-sqrt((i-ii)^2+(j-jj)^2)/(2*sigma_s^2)); %Poids spatial
                  w_c = exp(-sqrt(sum((I(i,j,:)-I(ii,jj,:))).^2)/(2*sigma_c^2)); %Poids couleur
                  weight = w_c*w_s;
                  %Si weight = 1 -> filtre moyenneur
                  img_bf(i,j,:) = img_bf(i,j,:) + weight*I(ii,jj,:);
                  sum_w = sum_w + weight;
             end
         end
       %Normalisation
       img_bf(i,j,:) = img_bf(i,j,:)/sum_w;
    end
end 
figure, 
imagesc(uint8(img_bf))
colormap(gray)
