from easygui import *

nimi = enterbox("Palun sisesta oma nimi: ")
vanus = integerbox("Palun sisesta oma vanus: ", lowerbound=1, upperbound=120)
aadress = enterbox("Palun sisesta oma aadress: ")

failinimi = filesavebox()

f = open(failinimi, "w")
f.write(nimi + "\n")
f.write(str(vanus) + "\n")
f.write(aadress + "\n")
f.close()

failinimi = fileopenbox()

f = open(failinimi)

nimi = f.readline().strip()
vanus = f.readline().strip()
aadress = f.readline().strip()

f.close()

tekst = "Nimi: " + nimi + "\n" + "Vanus: " + vanus + " aastat\n" + "Aadress: " + aadress

msgbox(tekst)
