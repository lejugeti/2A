clear all
close all
clc

size=255;
radius=70;
dist=45;

[R,G,B] = p1_ex_disks(size,radius,dist);

%Conversion au format uint8 [0, 255]
C1=uint8(R*255);
C2=uint8(G*255);
C3=uint8(B*255);

%Cr�er l'objet vid�o avec VideoWriter (à compl�ter)
v = VideoWriter('disk_uncompressed.avi', 'Uncompressed AVI');
    
%D�finir le frame rate
v.FrameRate = 5;
    
%Ouvrir de l'objet vid�o
open(v)
    
for n=1:100
    
    q=mod(n,3);
    
    switch q
        case 0  %C1=Rouge-C2=Vert-C3=Bleu
            img = cat(3,C1,C2,C3);
        case 1  %C3,C1,C2 (à compl�ter)
            img = cat(3,C3,C1,C2);
        case 2  %C2,C3,C1 (à compl�ter)
            img = cat(3,C2,C3,C1);
    end
    
    %Ajout du frame dans la vid�o
    frame = img;
    writeVideo(v,frame);
        
end
%Fermeture de l'objet vid�o
close(v)