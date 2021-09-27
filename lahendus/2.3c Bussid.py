from math import ceil

reisijaid = int(input("Mitu reisijat on? "))
kohtiBussis = int(input("Kohtade arv bussis: "))
busseVaja = ceil(reisijaid / kohtiBussis)
# if kohtiBussis * busseVaja < reisijaid:
#     busseVaja += 1
print("Busse vaja:", busseVaja)
viimasesReisijaid = reisijaid % kohtiBussis
if reisijaid > 0 and viimasesReisijaid == 0:
    viimasesReisijaid = kohtiBussis
print("Viimases bussis inimesi:", viimasesReisijaid)
