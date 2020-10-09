import pandas as pd
import re 

path = "H:\\rep.xlsx"
rep = pd.read_excel(path)

rep.drop(columns="Horodateur", inplace=True)
rep.columns = ["nom", "prenom", "famille", "participe", "path", "message", "contact"]

#on change les réponses de participation pour que ça soit plus facilement utilisable
p = rep["participe"]
p[p=="Non non non"] = "non"
p[p=="Oui monsieur"] = "oui"
rep["participe"] = p

#on check les numéros de tel
pattern = "^0[6-7][0-9]{8}$"

for i in range(len(rep)):
    testNum = re.match(pattern, rep["contact"][i])

    if(not testNum):
        rep["contact"][i] = "null"


rep.to_json("H:\\rep.json", orient="index")

print(rep)
