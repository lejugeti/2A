n = 1000
sigma = 3
t = 50
b1 = 3
b0 = 2

e = rnorm(n,1,sigma)
x = runif(n,0, t)
y = b1 * x + b0 + e

plot(x,y)
#abline(b0, b1, col="red")

res = lm(y~x)
summary(res)
abline(res, col="red")

#On regarde la distribution des r�sidus pour voir s'il y a normalit�
hist(res$residuals)


# Graphs utiles pour juger de la qualit� du mod�le ------------------------

par(mfrow=c(1,2))

#on regarde les r�sidus en fonction des valeurs pr�dites
plot(res$fitted.values, res$residuals)
abline(h=0, col=2)

#comparaison des valeurs r�elles avec celles pr�dites
plot(res$fitted, y)
abline(0,1,col=2)

#�tude des r�sidus studentis�s
par(mfrow=c(1,1))
residus_stud = rstudent(res)
plot(residus_stud, ylab="res. student", ylim=c(-3.5, 3.5))
abline(h=c(-2,0,2), lty=c(2,1,2))


# pr�diction avec le mod�le -----------------------------------------------

res = lm(y~x)
x0 = data.frame(x=2)
predict(res, new=x0, interval="pred", level=0.95)#estimation yo
predict(res, new=x0, interl="conf", level=0.95)#estimation de E[y sachant x0], avec E l'esp�rance


