#%%
import pandas as pd
import re 
import os

path = "E:/Cours/ensc/2A/BDF/"
#path = "../BDF/"
rep = pd.read_excel(path + "rep.xlsx")

rep.drop(columns="Horodateur", inplace=True)
rep.columns = ["nom_2A", "prenom_2A", "famille", "participe", "path", "message", "contact"]

#on met tous les noms en upper + drop prénoms
rep.nom_2A = rep.nom_2A.str.upper()
rep.drop(columns="prenom_2A", inplace=True)

#on change les réponses de participation pour que ça soit plus facilement utilisable
p = rep["participe"]
p[p=="Non non non"] = "non"
p[p=="Oui monsieur"] = "oui"
rep["participe"] = p

#on check les numéros de tel
patternNum = "^0[6-7][0-9]{8}$"

for i in range(len(rep)):
    testNum = re.match(patternNum, rep["contact"][i])

    if(not testNum):
        rep["contact"][i] = "aucun" 

#rep.contact = rep.contact.astype(str)
#rep.to_json(path + "rep.json", orient="index")

print(rep)

#%% join des tableaux

#liste1A = pd.read_excel("E:/Cours/ensc/2A/BDF/1A.xlsx")
liste1A = pd.read_excel("../BDF/1A.xlsx")
finalListe = pd.merge(liste1A, rep, on="nom_2A")
finalListe.to_excel(path + "liste_merged.xlsx")
print(finalListe)

#%% ajout des paths photos

df = pd.read_excel(os.path.join(path, "liste_merged.xlsx"))
photos = os.listdir(os.path.join(path, "photos"))

for line in df.iterrows():
    lineData = line[1] #pour accéder aux données du Series
    
    changementPath = False
    tempNom = lineData.nom_2A.lower()
    tempPrenom = lineData.prenom_2A.lower()
    patternPhoto = f"{tempNom}"

    for p in photos:
        pName, pExt = os.path.splitext(p)
        pName = pName.lower()
        match = re.search(patternPhoto, pName)
        
        if(match):
            newPath = os.path.join(path, "photos", f"{tempNom}_{tempPrenom}{pExt}")
            os.rename(os.path.join(path, "photos", p), newPath)
            df.path[line[0]] = os.path.join(f"./photos/{tempNom}_{tempPrenom}{pExt}")
            changementPath = True
    
    #on enlève le path google drive s'il n'y a pas de photo fournie
    if(not changementPath): 
        df.path[line[0]] = "null"
    
#%% écriture du tableau final

df.to_excel(os.path.join(path, "liste_merged.xlsx"))
df.to_json(os.path.join(path, "liste_parrainage.json"), orient="index")
