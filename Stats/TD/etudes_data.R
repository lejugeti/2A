load(file="./data/appartements.Rda")
apt = appartements
x = apt$surface
y = apt$prix
plot(apt$surface, apt$prix)

res = lm(apt$prix~x)
summary(res)

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
