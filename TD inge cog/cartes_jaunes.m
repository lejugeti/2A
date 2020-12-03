%% main avec génération de toutes les vidéos 

clc
clear all

% effacement des vidéos déjà présentes
delete ./augmentation_teinte/*.avi
delete ./diminution_teinte/*.avi
delete ./luminosite/*.avi
delete ./saturation/*.avi

%Creation image jaune
frame0 = zeros(1080,1920,3);
frame0 = uint8(frame0);
frame0(:,:,1) = 255;
frame0(:,:,2) = 255;

index_waitbar = 0;
w = waitbar(index_waitbar, 'création des vidéos');

% création vidéos diminution teinte
for i = 1:5
   x = randi([100, 1800]); 
   y = randi([100, 980]);
   randLettre = randi([1, 4]);
   
   if(randLettre == 1)
       lettre='e';
   elseif(randLettre == 2)
       lettre='f';   
   elseif(randLettre == 3)
       lettre='h'; 
   elseif(randLettre == 4)
       lettre='t';
   end
   
   v = VideoWriter(sprintf('./diminution_teinte/diminution_teinte_%s_%d', lettre, i));
   v.FrameRate = 1;
   open(v);
   newFrame = frame0;
   
   for j=0:63
    %Baisse de 4 du G pour une baisse de environ de 1° de la teinte par seconde
    newFrame(:,:,2) = 255-4*j;
    newFrame = dessin(newFrame, lettre, x, y);
    writeVideo(v,newFrame)
   end
   
   close(v);
   index_waitbar = index_waitbar + 1;
   waitbar(index_waitbar/20);
end

% création vidéos augmentation teinte
for i = 1:5
   x = randi([100, 1800]); 
   y = randi([100, 980]);
   randLettre = randi([1, 4]);
   
   if(randLettre == 1)
       lettre='e';
   elseif(randLettre == 2)
       lettre='f';   
   elseif(randLettre == 3)
       lettre='h'; 
   elseif(randLettre == 4)
       lettre='t';
   end
   
   v = VideoWriter(sprintf('./augmentation_teinte/augmentation_teinte_%s_%d', lettre, i));
   v.FrameRate = 1;
   open(v);
   newFrame = frame0;
   
   for j=0:63
	%Baisse de 4 du R pour une augmentation de environ de 1° de la teinte par seconde
	newFrame(:,:,1) = 255-4*j;
	newFrame = dessin(newFrame, lettre, x, y);
	writeVideo(v,newFrame)
   end
   
   close(v);
   index_waitbar = index_waitbar + 1;
   waitbar(index_waitbar/20);
end

% création vidéos saturation
for i = 1:5
   x = randi([100, 1800]); 
   y = randi([100, 980]);
   randLettre = randi([1, 4]);
   
   if(randLettre == 1)
       lettre='e';
   elseif(randLettre == 2)
       lettre='f';   
   elseif(randLettre == 3)
       lettre='h'; 
   elseif(randLettre == 4)
       lettre='t';
   end
   
   v = VideoWriter(sprintf('./saturation/saturation_%s_%d', lettre, i));
   v.FrameRate = 1;
   open(v);
   newFrame = frame0;
   
    for j=0:63
        %Augmentation de 4 du B pour une baisse de environ de 1% de la saturation par seconde
        newFrame(:,:,3) = 4*j;
        newFrame = dessin(newFrame, lettre, x, y);
        writeVideo(v,newFrame)
    end
   
   close(v);
   index_waitbar = index_waitbar + 1;
   waitbar(index_waitbar/20);
end

% création vidéos luminosité
for i = 1:5
   x = randi([100, 1800]); 
   y = randi([100, 980]);
   randLettre = randi([1, 4]);
   
   if(randLettre == 1)
       lettre='e';
   elseif(randLettre == 2)
       lettre='f';   
   elseif(randLettre == 3)
       lettre='h'; 
   elseif(randLettre == 4)
       lettre='t';
   end
   
   v = VideoWriter(sprintf('./luminosite/luminosite_%s_%d', lettre, i));
   v.FrameRate = 1;
   open(v);
   newFrame = frame0;
   
    for j=0:85
        %Diminution de 3 du R et G pour une baisse de environ de 1% de la luminosité par seconde
        newFrame(:,:,1) = 255-3*j;
        newFrame(:,:,2) = 255-3*j;
        newFrame = dessin(newFrame, lettre, x, y);
        writeVideo(v,newFrame)
    end
   
   close(v);
   index_waitbar = index_waitbar + 1;
   waitbar(index_waitbar/20);
end

close(w);
%% Fonctions écriture lettres

function [newFrame] = dessin(frame, lettre, x, y)
    if(lettre=='e')
        newFrame = dessinE(frame,x,y);
    
    elseif(lettre=='f')
        newFrame = dessinF(frame,x,y);
    
    elseif(lettre=='h')
        newFrame = dessinH(frame,x,y);
    
    elseif(lettre=='t')
        newFrame = dessinT(frame,x,y);
    end
    
end

function [newFrame] = dessinE(frame, x, y)

	%Barre verticale
	frame(y-75:y+75,x-10:x+10,1) = 255;
	frame(y-75:y+75,x-10:x+10,2) = 255;
	frame(y-75:y+75,x-10:x+10,3) = 0;
	%Barre horizontale basse
	frame(y+60:y+75,x-10:x+85,1) = 255;
	frame(y+60:y+75,x-10:x+85,2) = 255;
	frame(y+60:y+75,x-10:x+85,3) = 0;
	%Barre horizontale mediane
	frame(y-10:y+10,x-10:x+85,1) = 255;
	frame(y-10:y+10,x-10:x+85,2) = 255;
	frame(y-10:y+10,x-10:x+85,3) = 0;
	%Barre horizontale haute
	frame(y-75:y-60,x-10:x+85,1) = 255;
	frame(y-75:y-60,x-10:x+85,2) = 255;
	frame(y-75:y-60,x-10:x+85,3) = 0;
    
	newFrame = frame;
end

function [newFrame] = dessinT(frame, x, y)
	%Barre horizontale haute
	frame(y-75:y+75,x-10:x+10,1) = 255;
	frame(y-75:y+75,x-10:x+10,2) = 255;
	frame(y-75:y+75,x-10:x+10,3) = 0;
	%Barre verticale
	frame(y-75:y-60,x-60:x+60,1) = 255;
	frame(y-75:y-60,x-60:x+60,2) = 255;
	frame(y-75:y-60,x-60:x+60,3) = 0;
    
	newFrame = frame;
end

function [newFrame] = dessinF(frame, x, y)
	%Barre verticale
	frame(y-75:y+75,x-10:x+10,1) = 255;
	frame(y-75:y+75,x-10:x+10,2) = 255;
	frame(y-75:y+75,x-10:x+10,3) = 0;
	%Barre horizontale mediane
	frame(y-10:y+10,x-10:x+85,1) = 255;
	frame(y-10:y+10,x-10:x+85,2) = 255;
	frame(y-10:y+10,x-10:x+85,3) = 0;
	%Barre horizontale haute
	frame(y-75:y-60,x-10:x+85,1) = 255;
	frame(y-75:y-60,x-10:x+85,2) = 255;
	frame(y-75:y-60,x-10:x+85,3) = 0;
    
	newFrame = frame;
end

function [newFrame] = dessinH(frame, x, y)
	%Barre verticale gauche
	frame(y-75:y+75,x-50:x-30,1) = 255;
	frame(y-75:y+75,x-50:x-30,2) = 255;
	frame(y-75:y+75,x-50:x-30,3) = 0;
	%Barre verticale droite
	frame(y-75:y+75,x+30:x+50,1) = 255;
	frame(y-75:y+75,x+30:x+50,2) = 255;
	frame(y-75:y+75,x+30:x+50,3) = 0;
	%Barre horizontale mediane
	frame(y-10:y+10,x-30:x+30,1) = 255;
	frame(y-10:y+10,x-30:x+30,2) = 255;
	frame(y-10:y+10,x-30:x+30,3) = 0;
    
	newFrame = frame;
end



