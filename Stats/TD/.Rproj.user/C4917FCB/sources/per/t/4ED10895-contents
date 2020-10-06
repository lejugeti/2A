load(file="./data/appartements.Rda")
apt = appartements
x = apt$surface
y = apt$prix
plot(apt$surface, apt$prix)

res = lm(apt$prix~x)
summary(res)

new = data.frame(x=seq(20, 110, by=10))

predict(object=res, newdata=new, interval="pred", level=0.95)
