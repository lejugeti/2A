
%% Import des fichiers
load clase160;
load sessiontotal;

%% filtrage 

w = [10 12] / 64;
[B, A] = butter(5, w);

gaucheFiltre = filter(A, B, y(:,1));
droiteFiltre = filter(A, B, y(:,2));
%% trames
clc

G0 = zeros(80, 1152);
D0 = zeros(80, 1152);
G1 = zeros(80, 1152);
D1 = zeros(80, 1152);

indexTrame0 = 1;
indexTrame1 = 1;
indexCanal = 1;
for consigne = z(1,:)
    
    if(consigne == 0)
        G0(indexTrame0, :) = gaucheFiltre(indexCanal:indexCanal+1151,1)';
        D0(indexTrame0, :) = droiteFiltre(indexCanal:indexCanal+1151,1)';
        indexTrame0 = indexTrame0 + 1;
    
    elseif(consigne == 1)
        G1(indexTrame1, :) = gaucheFiltre(indexCanal:indexCanal+1151,1)';
        D1(indexTrame1, :) = droiteFiltre(indexCanal:indexCanal+1151,1)';
        indexTrame1 = indexTrame1 + 1;
    end
    
    
    indexCanal = indexCanal + 1152;
end

%% moyenne des trames

meanD0 = mean(D0);
meanG0 = mean(G0);
meanD1 = mean(D1);
meanG1 = mean(G1);

%% recalage des trames

centreD0 = D0 - meanD0;
centreG0 = G0 - meanG0;
centreD1 = D1 - meanD1;
centreG1 = G1 - meanG1;

%% puissance des signaux

puissanceD0 = D0.^2;
puissanceG0 = G0.^2;
puissanceD1 = D1.^2;
puissanceG1 = G1.^2;

%% puissance moyenne à chaque instant

meanPuiD0 = mean(puissanceD0);
meanPuiG0 = mean(puissanceG0);
meanPuiD1 = mean(puissanceD1);
meanPuiG1 = mean(puissanceG1);


%% puissances au repos

% 0.5 -> 1.5 sec  <-> 64 -> 192
puiRepoD0 = puissanceD0(:, 64:192);
puiRepoG0 = puissanceG0(:, 64:192);
puiRepoD1 = puissanceD1(:, 64:192);
puiRepoG1 = puissanceG1(:, 64:192);

meanPuiRepoD0 = mean(puiRepoD0);
meanPuiRepoG0 = mean(puiRepoG0);
meanPuiRepoD1 = mean(puiRepoD1);
meanPuiRepoG1 = mean(puiRepoG1);

%% matrices d'écart à la puissance au repos

ecartD0 = (mean(puissanceD0,2) - meanPuiRepoD0) * 100 / meanPuiRepoD0;
ecartG0 = (mean(puissanceG0,2) - meanPuiRepoG0) * 100 / meanPuiRepoG0;
ecartD1 = (mean(puissanceD1,2) - meanPuiRepoD1) * 100 / meanPuiRepoD1;
ecartG1 = (mean(puissanceG1,2) - meanPuiRepoG1) * 100 / meanPuiRepoG1;


%% puissance par blocs

meanBlocD0 = [mean(ecartD0(1:16)), mean(ecartD0(17:32)), mean(ecartD0(33:48)), mean(ecartD0(49: 64)),mean(ecartD0(65:80))];
meanBlocG0 = [mean(ecartG0(1:16)), mean(ecartG0(17:32)), mean(ecartG0(33:48)), mean(ecartG0(49: 64)),mean(ecartG0(65:80))];
meanBlocD1 = [mean(ecartD1(1:16)), mean(ecartD1(17:32)), mean(ecartD1(33:48)), mean(ecartD1(49: 64)),mean(ecartD1(65:80))];
meanBlocG1 = [mean(ecartG1(1:16)), mean(ecartG1(17:32)), mean(ecartG1(33:48)), mean(ecartG1(49: 64)),mean(ecartG1(65:80))];

%% affichage résultats

figure,
subplot(2,2,1);
plot(meanBlocD0);
xlabel('bloc n°');
ylabel("% d'ecart");
title("Ecart trame D0");

subplot(2,2,2);
plot(meanBlocG0);
xlabel('bloc n°');
ylabel("% d'ecart");
title("Ecart trame G0");

subplot(2,2,3);
plot(meanBlocD1);
xlabel('bloc n°');
ylabel("% d'ecart");
title("Ecart trame D1");

subplot(2,2,4);
plot(meanBlocG1);
xlabel('bloc n°');
ylabel("% d'ecart");
title("Ecart trame G1");





























