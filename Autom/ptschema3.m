clear all;
clc;

NumG = [1];
DenG = [1/(16.89*50) 1/16.89 0];

NumC = [1];
DenC = [1];

Stepte = 0;  Ive = 0;  Fve = 1;

SteptPu = 5;  IvPu = 0;  FvPu = 1;

SteptPs = 10;  IvPs = 0;  FvPs = 1;

Startt = 0; Stopt = 15;

DataHistory = 15000;

SampleTime = 0.001;

a = sim("schema3");

figure(1);
plot(a.t, a.s);
grid;

figure(2);
plot(a.t, a.u);
grid;


%% étude des sorties du système 

Startt = 0; stopt = 15;

pwmin=-2;
pwmax = 3;
nw = 100;
w = logspace(pwmin, pwmax, nw);

[a,b,c,d] = linmod("schema4");

i = 1;
j = 1;

[g, p] = bode(a,b,c,d,i,w);
gDB = 20*log10(g);

figure(1)
subplot(2,1,1);
semilogx(w, gDB(:,j));
grid;

subplot(2,1,2);
semilogx(w, p(:,j));
grid;