n = 100
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
