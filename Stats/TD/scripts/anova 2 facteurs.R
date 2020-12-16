load("data/plaques.Rda")

plot(rugosite~duree, plaques)

res = lm(rugosite~duree, data=plaques)
anova(res)
