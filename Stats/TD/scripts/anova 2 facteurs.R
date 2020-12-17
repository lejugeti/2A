rendement<-c(15,14,17,18,17,18,12,13,12,14,15,15,
             16,19,18,23,24,25,15,14,14,12,11,10,
             18,17,17,20,21,21,17,19,17,12,13,12)
plant<-as.factor(rep(rep(c("Plant I","Plant II","Plant III","Plant IV"),each=3),3))
engrais<-as.factor(rep(c("Engrais A","Engrais B","Engrais C"),each=12))
donnees<-data.frame(rendement,plant,engrais)
levels(engrais) # donne les differents niveaux du facteur "engrais"
levels(plant) # donne les differents niveaux du facteur "plant"
table(engrais) # indique les nombres d’observations par niveau du facteur "engrais"
table(plant) # indique les nombres d’observations par niveau du facteur "plant"
table(plant,engrais)

boxplot(rendement~engrais*plant)
boxplot(rendement~plant)
boxplot(rendement~engrais)

interaction.plot(plant,engrais,rendement)
interaction.plot(engrais,plant,rendement)

tapply(rendement,list(engrais,plant),mean)
tapply(rendement,list(engrais,plant),min)
tapply(rendement,list(engrais,plant),var)

res.aov <- aov(rendement~engrais*plant) # modele avec interaction
summary(res.aov)

res<-lm(rendement~engrais*plant) # calage sur la case "Type I" et "Engrais A"
summary(res)
