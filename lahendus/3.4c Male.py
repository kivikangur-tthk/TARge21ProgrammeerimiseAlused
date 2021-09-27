laud = 64
kokku = 0
ruuduNr = int(input("Sisestage täisarv: "))
if ruuduNr > 0:
    kokku = 1
kord = 1
while kord < ruuduNr:
    kord += 1
    kokku = kokku * 2
print("Nisuteri " + str(ruuduNr) + ". ruudu eest:", kokku)
