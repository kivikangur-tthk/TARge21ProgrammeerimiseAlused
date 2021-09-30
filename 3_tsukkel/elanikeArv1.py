aasta = 2017  # loendamist ei pea nullist alustama
arv = 1315635
iibe_kordaja = -1.33  # Promillides (arvukuse muutus 1000 elaniku kohta)
while aasta < 2080:
    arv = arv + arv * iibe_kordaja / 1000  # Arvutame selle aasta uue arvu
    aasta = aasta + 1  # Läheme järgmise aasta juurde
print("Aastal " + str(aasta) + " on elanikke " + str(round(arv)) + ".")
