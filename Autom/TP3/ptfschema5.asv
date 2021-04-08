%%

clear all
close all
clc

% prompt = {'Gain statique','wp0','w0'};
% dlgtitle = 'Procede';
% line = 1;
% def = {'1','16.89','50'};
% 
% procede = inputdlg(prompt, dlgtitle, line, def);
% G0 = str2num(strvcat(procede(1)));
% wp0 = str2num(strvcat(procede(2)));
% w0 = str2num(strvcat(procede(3)));
% 
% NumG = [G0];
% DenG = [1/(wp0*w0) 1/wp0 0];
% G=tf(NumG, DenG) ;
% 
% W00 = min(w0,wp0);
% Startt = 0; Stopt = 200/W00; Nt=100;
% t=linspace(Startt, Stopt, Nt);
% 
% nw = 100;
% ndec = 2;
% pwmin = round(log10(W00/(10^ndec)));
% pwmax = round(log10(W00*(10^ndec)));
% w = logspace(pwmin,pwmax,nw);

K1=0;
while(K1~=6)
    K1=menu('Titre Menu principal', 'Saisie procédé G(s)', ' Etude du procédé G(jw)', 'Synthèse régulateur PIDF', 'Etude Beta(jw)', 'Etude de l’asservissement en t et en w', 'Exit');
    if(K1==1)
        prompt = {'Gain statique','wp0','w0'};
        dlgtitle = 'Procede';
        line = 1;
        def = {'1','16.89','50'};

        procede = inputdlg(prompt, dlgtitle, line, def);
        G0 = str2num(strvcat(procede(1)));
        wp0 = str2num(strvcat(procede(2)));
        w0 = str2num(strvcat(procede(3)));

        NumG = [G0];
        DenG = [1/(wp0*w0) 1/wp0 0];
        G=tf(NumG, DenG) ;

        W00 = min(w0,wp0);
        Startt = 0; Stopt = 200/W00; Nt=100;
        t=linspace(Startt, Stopt, Nt);

        nw = 100;
        ndec = 2;
        pwmin = round(log10(W00/(10^ndec)));
        pwmax = round(log10(W00*(10^ndec)));
        w = logspace(pwmin,pwmax,nw);
        
        [g,p,w] = bode(G);
    end;
    
    if(K1==2) 
        K2=0;
        while(K2~=3)
            K2 = menu('Etude du procédé G(jw)', 'Bode','Nichols', 'Retour');
            if(K2==1)
                bode(G);
                grid;
		    end ;
            if(K2==2)
              nichols(G);
              grid;
		   end ;
           if(K2==3)
               close all;
           end
        end;

    if(K1==3)
         K3=0;
         while(K3~=3)
            K3 = menu('Etude du procede G', 'Bode', 'Nichols', 'Retour');
            if(K3==1)
                prompt = {'wu','Mphi','alpha'}; % alpha est un rapport entre wi
                dlgtitle = 'Procede';
                line = 1;
                def = {'10','-45','50'};

                procede = inputdlg(prompt, dlgtitle, line, def);
                wu = str2num(strvcat(procede(1)));
                Mphi = str2num(strvcat(procede(2)));
                alpha = str2num(strvcat(procede(3)));
                
                [NumC, DenC] = f_pidf(wu, Mphi, alpha);
                C = tf(NumC, DenC);
                
                bode(C);
                nichols(C);
		    end ;
%    ….
% 		…
         end ;
    end;

%    ……
    end;
end;




%%

clear all
close all
clc

%Initialisation
NumG=[1];
DenG=[1/(16.89*50)  1/16.89 0];

NumC=[1];
DenC=[1];

DataHistory=15000;

Stepte=0;  Ive=0;  Fve=1;
SteptPu=5;  IvPu=0;  FvPu=1;
SteptPs=10;  IvPs=0;  FvPs=1;

Startt=0;   Stoptt=15;
Sampletime=0.001;

pwmin=-2;
pwmax=3;
nw=100;
w = logspace(pwmin,pwmax,nw);


%Lancement de la simulation féquentielle
[a,b,c,d] = linmod('tfschema5'); 

i=1;
j=1;

[g,p] = bode(a,b,c,d,i,w) ; %(tous les diagrammes de Bode par rapport à l'entrée n°i de 1 à 3)
gdB = 20*log10(g);

figure(1)
subplot(211)
semilogx(w,gdB(:,j)); %(diagrammes de gain par rapport à la sortie n°j =1 ou 2)
grid;

subplot(212)
semilogx(w,p(:,j)); %(diagrammes de gain par rapport à la sortie n°j =1 ou 2)
grid;

%Lancement de la simulation temporelle
[t,x,y]=sim('tfschema5'); 

figure(2)
plot(t,y(:,1)); %Y est le vecteur des out
grid;

figure(3)
plot(t,y(:,2));
grid;




