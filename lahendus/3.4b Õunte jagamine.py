from random import randint

pöialpoisse = int(input("Mitu pöialpoissi tahab õunu? [0-7]"))
õunu = 14
while pöialpoisse > 0:
    mitu = randint(1, 2)
    print(mitu)
    õunu -= mitu
    pöialpoisse -= 1
print("Lumivalgekesele jäi", õunu)
