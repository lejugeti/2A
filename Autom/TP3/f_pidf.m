function [NumC,DenC] = f_pidf(wu, Mphi, alpha, G)
    ti = 10/wu;
    tf = 1/(10*wu);
    
    argCG = -180 + Mphi;
    [g,p,w] = bode(G)
    
    phi = 0;
    
    a = (1+sin(phi))/(1-sin(phi));
    ta = sqrt(a)/wu;
    tb = 1/(wu*sqrt(a));

end

