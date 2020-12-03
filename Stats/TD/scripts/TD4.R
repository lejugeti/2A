donnees <- data.frame(engraisA=c(48,49,50,49),engraisB=c(47,49,48,48),engraisC=c(49,51,50,50))
donnees
stack(donnees) # cette fonction R permet d’empiler les colonnes d’un tableau de donnees
rendement <- stack(donnees)$values
engrais <- stack(donnees)$ind
is.factor(engrais) # on peut verifier que la variable "engrais" est bien de type "facteur"
# ou
class(engrais) # permet de verifier de quelle type est la variable "engrais"
class(rendement) # permet de verifier de quelle type est la variable "rendement"

df = stack(donnees)
colnames(df) = c("rendement", "engrais")

table(engrais) #tableau de contingence des modalités d'engrais

plot(rendement~engrais) # permet d’obtenir les boxplots paralleles du rendement
                        # par type d’engrai


apply(donnees,2,summary)
apply(donnees, 2, var) # voir variance de chaque grp

res.aov <- aov(rendement~engrais)
summary(res.aov)


# pour se caler sur le troisieme groupe C
#------------------------------
res <- lm(rendement~C(engrais,base=3))
summary(res)

shapiro.test(res$residuals) # test de normalite des residus
bartlett.test(rendement,engrais) # test d’homoscedasticite
plot(res$fitted,res$residuals) # graphique des valeurs predites versus les residus

# comparaisons deux à deux des modalités
pairwise.t.test(rendement,engrais,p.adjust="bonf")



# Etude jeu de données lampes ---------------------------------------------

load(file = "./data/lampes.Rda")

plot(lampes$duree~lampes$procede)

res = lm(duree~procede, data=lampes)
summary(res) #ici modèle calé sur la moyenne de la première modalité P1
anova(res)
