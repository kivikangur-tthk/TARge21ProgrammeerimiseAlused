kasutaja_nimi = input("Sisesta oma kasutajanimi: ")
sisestatud_pin = input("Sisesta PIN-kood: ")
if kasutaja_nimi.lower() == "siil" and sisestatud_pin == "1234":
    kontoseis = 100
    print("Tere " + kasutaja_nimi + ". Sisenesid pangaautomaati!")
    print("Kontol on", kontoseis, "eurot")
    print("Sisesta, mitu eurot soovid välja võtta:")
    soovitud_raha = int(input())
    if kontoseis >= soovitud_raha and soovitud_raha > 0:
        #        kontoseis = kontoseis - soovitud_raha
        kontoseis -= soovitud_raha
        print("Ärge unustage raha automaadist välja võtta")
    else:
        print("Raha ei ole piisavalt")
    print("Pangakontol on nüüd: " + str(kontoseis) + " eurot.")
else:
    print("Vale parool! Ligipääs keelatud!")
