# Koosta programm, mis aitab lastel treenida liitmist. Programm peaks pakkuma välja juhuslike arvudega liitmistehteid ning ootama kasutajalt vastust. Kui vastus on õige, kiitma kasutajat, kui aga vale, andma õige vastuse ja esitama uue tehte. Järjest esitatavate tehete hulk võib olla programmis ette antud (näiteks 10), samuti võib olla ette antud piirid, kui suuri arve kasutajalt küsitakse (näiteks 1 kuni 50). Programm peaks pidama arvestust ka õigete vastuste üle ning väljastama pärast viimast tehet tulemuse. Näiteks:
#
# Tere! Õpime arvutama. Esitan 10 liitmistehet, püüa vastata õigesti.
# 5 + 16 =
# >> 21
# Tubli, õige vastus!
# 18 + 23 =
# >> 39
# Sinu vastus polnud õige. Õige vastus on 41.
# [...]
# 2 + 5 =
# >> 7
# Tubli, õige vastus!
# See oli viimane ülesanne. Kogusid 10-st punktist 7.
# Täiendusi vabal valikul:
#
# Programm lubab kasutajal alguses sisestada, mitut tehet soovitakse.
# Esitatavate arvude piirid saab kasutaja ette anda (maksimum või nii miinimum kui maksimum).
# Küsitakse mitte ainult liitmistehteid, vaid ka teisi (lahutamine, korrutamine, jagamine).
# Vastavalt lõpptulemusele reageeritakse erinevalt: "Ülihea!", "Olid tubli!", "Korralik keskmine tulemus!", "Püüad järgmisel korral rohkem." vms.

from random import randint

õigeid = 0
tehteid = int(input("Mitu tehet soovid teha? "))
minArv = int(input("Milline on väikseim arv? "))
maksArv = int(input("Milline on suurim arv? "))
for i in range(tehteid):
    arv1 = randint(minArv, maksArv)
    arv2 = randint(minArv, maksArv)
    tehe = randint(1, 3)
    if tehe == 1:
        vastus = int(input(str(arv1) + "+" + str(arv2) + "= "))
        if vastus == arv1 + arv2:
            print("Tubli!")
            õigeid += 1
        else:
            print("See läks mööda. Pinguta rohkem.")
    elif tehe == 2:
        vastus = int(input(str(arv1) + "-" + str(arv2) + "= "))
        if vastus == arv1 - arv2:
            print("Tubli!")
            õigeid += 1
        else:
            print("See läks mööda. Pinguta rohkem.")
    else:
        vastus = int(input(str(arv1) + "*" + str(arv2) + "= "))
        if vastus == arv1 * arv2:
            print("Tubli!")
            õigeid += 1
        else:
            print("See läks mööda. Pinguta rohkem.")
print("Tehteid oli", tehteid, "\nVastasid õigesti", õigeid, "korda.")
protsent = õigeid * 100 / tehteid
print("Protsent:", protsent)
if protsent > 90:
    print("Suurepärane")
elif protsent > 50:
    print("Üle keskmise")
else:
    print("On vaja veel harjutada")
