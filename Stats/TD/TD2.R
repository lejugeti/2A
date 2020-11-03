# début tp régression multiple --------------------------------------------

n = 100
x1 = runif(n, min=-5, max=5)
x2 = runif(n, min=-5, max=5)
x3 = runif(n, min=-5, max=5)
x4 = runif(n, min=-5, max=5)
x5 = runif(n, min=-5, max=5)
sigma=2
e = rnorm(n, 0, sigma)

y = 4 - 2*x1 + 3 * x2 - 5*x3 + 0.8*x4 + 1.4*x5 + e
matXY = data.frame(y, x1, x2, x3, x4, x5)
plot(matXY) #plot des données 2 à 2

res = lm(y~x1+x2+x3+x4+x5, data=matXY)
summary(res)

par(mfrow=c(1,2))
#on regarde distribution des résidus pour voir s'il y a une structure dedans
plot(res$fitted,res$residuals)
abline(h=0)

#si bon modèle alors toutes les valeurs doivent être sur la première bisectrice
plot(res$fitted,y) 
abline(0,1, col="red")

#test de la normalité de distribution des résidus
shapiro.test(res$residuals)


# Voir comment modèle se comporte avec une variable explicative en  --------
y = 4 - 0*x1 + 3 * x2 - 5*x3 + 0.8*x4 + 1.4*x5 + e
matXY = data.frame(y, x1, x2, x3, x4, x5)
res = lm(y~x1+x2+x3+x4+x5, data=matXY)
summary(res)

#si coefficient estimé n'est pas utile car pas significatif alors on peut l'enlever
#donc création d'un nouveau modèle sans x1, ce qui enlève du bruit
#on le voit en regardant le R² car il augmente ou diminue
res = lm(y~x2+x3+x4+x5, data=matXY)
summary(res)


# suppression d'une variable explicative avec le critère AIC --------------

y = 4 - 2*x1 + 3 * x2 - 5*x3 + 0.8*x4 + 1.4*x5 + e
matXY = data.frame(y, x1, x2, x3, x4, x5)
res = lm(y~x1+x2+x3+x4+x5, data=matXY)


# ajout / retrait de variables du modèle ----------------------------------

n = 100
x1 = runif(n, min=-5, max=5)
x2 = runif(n, min=-5, max=5)
x3 = runif(n, min=-5, max=5)
x4 = runif(n, min=-5, max=5)
x5 = runif(n, min=-5, max=5)
sigma=2
e = rnorm(n, 0, sigma)

y = 4 - 2*x1 + 3 * x2 - 5*x3 + 0.8*x4 + 1.4*x5 + e
matXY = data.frame(y, x1, x2, x3, x4, x5)
res = lm(y~x1+x2+x3+x4+x5, data=matXY)

# <none> est la ligne pour le modèle de base. Toutes les autres lignes sont pour 
# les modèles privés de la variable de la ligne.
# + critère AIC bas mieux c'est donc si sur une ligne on a un AIC haut alors il ne faut pas 
# supprimer cette variable du modèle
drop1(res)

res2 = lm(y~x1+x2, data=matXY)
add1(res2, ~x1+x2+x3+x4+x5) #on propose toute une liste qui peut rentrer dans le modèle

# parfois il peut être intéressant de rajouter une variable puis une autre pour obtenir le meilleur modèle possible
# donc travailler pas à pas est fondamental 


# sélection automatique avec step -----------------------------------------

# la fonction cherche pas à pas quelle est la meilleure variable à ajouter au modèle
# les variables sont classées en fonction du critère AIC en ascendant
# On nous passe à titre informatif la commande pour obtenir le meilleur modèle + les coefficients du modèle
res = lm(y~x3, data=matXY)
step(res, ~x1+x2+x3+x4+x5)
