meesteKonstant = 220
naisteKonstant = 206
terviseTreeningAlates = 50
terviseTreeningKuni = 70
vastupidavusAlates = 70
vastupidavusKuni = 80
aeroobneAlates = 80
aeroobneKuni = 87
tervisetreening = 1
vastupidavustreening = 2
aeroobnetreening = 3
vanus = int(input("Sisestage enda vanus: "))
sugu = input("Sisestage enda sugu (m/n): ")
print("1 - tervisetreening,\n2 - põhivastupidavuse treening,\n3 - intensiivne aeroobne treening")
tüüp = int(input("Sisestage treeningu tüüp (1-3): "))
aluminePulss = -1
üleminePulss = -1
baasPulss = -1
if sugu.lower() == "m":
    baasPulss = meesteKonstant - vanus
elif sugu.lower() == "n":
    baasPulss = naisteKonstant - vanus * 88 / 100
else:
    print("Sooks on valik mehe - m ja naise - n vahel")
if tüüp == tervisetreening:
    aluminePulss = baasPulss * terviseTreeningAlates / 100
    üleminePulss = baasPulss * terviseTreeningKuni / 100
if tüüp == vastupidavustreening:
    aluminePulss = baasPulss * vastupidavusAlates / 100
    üleminePulss = baasPulss * vastupidavusKuni / 100
if tüüp == aeroobnetreening:
    aluminePulss = baasPulss * aeroobneAlates / 100
    üleminePulss = baasPulss * aeroobneKuni / 100
print("Pulsi sagedus peaks olema vahemikus " + str(round(aluminePulss)) + " kuni " + str(round(üleminePulss)) + ".")
