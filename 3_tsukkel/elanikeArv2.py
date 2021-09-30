aasta = 2017
arv = 1315635
iibe_kordaja = 6
while arv < 2000000:
    arv = arv + arv * iibe_kordaja / 1000
    aasta = aasta + 1
print("Aastal " + str(aasta) + " on elanike arv " + str(round(arv)) + ".")
