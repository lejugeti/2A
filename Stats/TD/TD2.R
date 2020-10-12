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

res = lm(y~x1+x2+x3+x4+x5)
summary(res)
