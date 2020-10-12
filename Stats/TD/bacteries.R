load("./data/bacteries.Rda")
library(stringr)

nb_obs = dim(bacteries)[1]
sigma = 1
ut = rnorm(nb_obs, 0, sigma)
t = bacteries$t
nt = data.frame(bacteries$nt)
colnames(nt) = "nt"

reg1 = lm(nt$nt~t)

par(mfrow=c(2,1))
plot(bacteries$t, bacteries$nt)
abline(reg1$coefficients[1], reg1$coefficients[2], col='red')

new_nt = apply(X=nt, 1, FUN=log)
reg2 = lm(new_nt~t)
plot(t, new_nt)
abline(reg2$coefficients[1], reg2$coefficients[2], col='red')

par(mfrow=c(3,1))
plot(t, reg2$fitted)
abline(reg2)
plot(reg2$fitted, reg2$residuals)
abline(h=0, col='red')
residus_stud = rstudent(reg2)
plot(residus_stud, ylab="res. student", ylim=c(-3.5, 3.5))
abline(h=c(-2,0,2), lty=c(2,1,2))

beta = reg2$coefficients[2]
beta

t0 = data.frame(t=0)
n0 = predict(reg2, newdata=t0, interval = "pred", level=0.95)[1]
n0 = exp(n0)

str_interp("n0 = ${round(n0, 3)}")
