%% diagramme de bode d'un intégrateur

% p = tf('p'); % dérivateur
% bode(1/p);      % passage en intégrateur

w = logspace(-1,2,100);
g = 1./w;
gDB = 20*log10(g);
p = -90*ones(1,100);

figure, subplot(2,1,1);
semilogx(w, gDB);
xlabel('w (rad/s)');
ylabel('Module(DB)');

subplot(2,1,2);
semilogx(w,p);
xlabel('w (rad/s)');
ylabel('Phase(°)');

%% matrice 5x20

v = 1:20;
A = [v;v;v;v;v];

B = zeros(5,20);

for i=1:5
   B(i, :) = 1:20;
   
end

%% fonction transfert

numG = [1 2 3];
denG = [4 5 6 1];
numC = [1 2];
denC = [6 1];
numF = [5 7];
denF = [1 1];


% si B = C*G

% Solution avec des vecteurs
[numB, denB] = series(numC, denC, numG, denG);

% solution avec des objets

G = tf(numG, denG);
C = tf(numC, denC);
F = tf(numF, denF);
B = C*G;
H = B/(1 + B * F);

%diagramme de bode
bode(G, w);

% obtenir le gain et la phase pour la pulsation donnée
wu = 10;
[g, p] = bode(G, wu);

% diagramme de nichols
figure
nichols(G, w);
ngrid

% réponse indicielle
figure
step(H);
grid

%% etude d'un second ordre

G0 = 1;
wn = 1;
z = linspace(0.2, 2, 10);

% échelle en temps
tmin = 0; tmax = 20/wn; Nt=100;
t=linspace(tmin, tmax, Nt);

% échelle en pulsation
nw = 100;
ndec = 2;
pwmin = round(log10(wn/(10^ndec)));
pwmax = round(log10(wn*(10^ndec)));

w = logspace(pwmin,pwmax,nw);


% plot réponse indicielle
figure,
for val = z
    numG = [G0];
    denG = [2/wn 2*val/wn 1];
    G = tf(numG, denG);
    
    hold on
    step(G, t);
    
    
end
title('Réponse indicielle');
legend;
hold off;

% plot diagrammes de bode
figure,
for val = z
    numG = [G0];
    denG = [2/wn 2*val/wn 1];
    G = tf(numG, denG);
    
    hold on
    bode(G, w);
    
    
end
title('Diagrammes de Bode');
legend;
hold off;

% plot diagrammes de Nichols
figure,
for val = z
    numG = [G0];
    denG = [2/wn 2*val/wn 1];
    G = tf(numG, denG);
    
    hold on
    nichols(G, w);
    
    
end
title('Diagrammes de Nichols');
legend;
ngrid;
hold off;