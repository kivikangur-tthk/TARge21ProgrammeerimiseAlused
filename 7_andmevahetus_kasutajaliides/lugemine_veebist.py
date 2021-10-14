from urllib.request import urlopen

failVeebis = urlopen("https://courses.cs.ut.ee/2018/eprogalused/uploads/Main/mesipuu.txt")
baidid = failVeebis.read()
tekst = baidid.decode()  # baitidest saab sõne
ridadeKaupa = tekst.splitlines()  # sõne jaotatakse reavahetuse kohtadelt
failVeebis.close()
print(ridadeKaupa[4])  # rida indeksiga 4
print(ridadeKaupa[4][7])  # rida indeksiga 4 sümbol indeksiga 7

failVeebis = urlopen("http://www.cs.ut.ee")
baidid = failVeebis.read(121)  # 121 esimest
tekst = baidid.decode()  # baitidest saab sõne
print(tekst)
failVeebis.close()

# from webbrowser import *
# sona = input("Sisestage sõna: ")
# aadress = "http://www.eki.ee/dict/qs/index.cgi?Q=" + sona
# open(aadress)

failVeebis = urlopen(
    "https://courses.cs.ut.ee/2018/eprogalused/fall/uploads/Main/anton_hansen_tammsaare_tode_ja_oigus_i.txt")
baidid = failVeebis.read()
tekst = baidid.decode()  # baitidest saab sõne
ridadeKaupa = tekst.splitlines()  # sõne jaotatakse reavahetuse kohtadelt
failVeebis.close()

tõde = 0  # loendaja
õigus = 0  # loendaja

for rida in ridadeKaupa:  # ridade kaupa
    sõnad = rida.split()  # rea sõnad järjendisse
    for s in sõnad:  # sõnade kaupa
        if s.lower().strip(".,?") == "tõde" or "tõde" in s.lower().strip(".,?"):
            tõde += 1
        if s.lower().strip(".,?") == "õigus" or "õigus" in s.lower().strip(".,?"):
            õigus += 1

print("Failis sõna 'tõde' on", tõde, "korda.")
print("Failis sõna 'õigus' on", õigus, "korda.")
