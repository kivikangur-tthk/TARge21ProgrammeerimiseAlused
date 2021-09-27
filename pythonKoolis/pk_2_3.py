# Koosta lihtne kalkulaator.
# Kasutajalt küsitakse kaks arvu ja tehtemärk ning
# seejärel kuvatakse tehe koos vastusega.
# Näiteks:
# 
# Sisestage esimene arv: 2
# Sisestage teine arv: 3
# Sisestage tehe [+-*/]: +
# Tulemus: 2+3=5
arv1 = int(input("Sisestage esimene arv: "))
arv2 = int(input("Sisestage teine arv: "))
tehe = input('Sisestage tehe [+-*/]: ')

tulemus = 0

if tehe == "+":
    tulemus = arv1 + arv2
elif tehe == "-":
    tulemus = arv1 - arv2
elif tehe == "*":
    tulemus = arv1 * arv2
elif tehe == "/":
    tulemus = arv1 / arv2
else:
    print("Tundmatu tehe:", tehe)
    raise SystemExit
print("Tulemus:", str(arv1) + tehe + str(arv2) + "=" + str(tulemus))
