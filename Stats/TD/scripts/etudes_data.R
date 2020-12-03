load(file="./data/appartements.Rda")
apt = appartements
x = apt$surface
y = apt$prix
plot(x, y)
abline(res, col="red")

res = lm(y~x)
summary(res)

plot(res$fitted, res$residuals)
abline(h=0, col="red")

#test de normalité des résidus
shapiro.test(res$residuals)

new = data.frame(x=seq(20, 110, by=10))

#ce qui change entre conf et pred : conf fait l'intervalle de confiance du prix moyen, alors
#que pred est un intervalle de confiance du prix lui-même
inter_conf = data.frame(predict(object=res, newdata=new, interval="conf", level=0.95))
inter_conf = cbind(new, inter_conf)
predictions = data.frame(predict(object=res, newdata=new, interval="pred", level=0.95))
predictions = cbind(new, predictions)
inter_conf
predictions
