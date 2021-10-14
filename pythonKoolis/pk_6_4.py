"""
Koer, kass, jänes, sipelgasiil ja lendorav hakkasid vaidlema,
kellel on kõige pikem nimetus. Koosta programm, kus on antud loomanimede järjend.
Loo funktsioon, mis saab argumendina ette looma nime ning tagastab
(mitte ei trüki!) selle pikkuse. Lase programmil kutsuda funktsiooni välja iga
loomanimede järjendi elemendiga ning trükib ekraanile nime pikkuse.
Pärast pikkuste kontrollimist peab programm väljastama kõige pikema loomanime
(võrdsete pikkuste puhul võib esitada vaid ühe pikimatest).
"""

loomad = ["Koer", "kass", "jänes", "sipelgasiil", "lendorav"]


def annaPikkus(nimi):
    return len(nimi)


pikimNimi = max(loomad, key=len)
print(pikimNimi)

pikimNimi = ""
for loom in loomad:
    if annaPikkus(loom) > annaPikkus(pikimNimi):
        pikimNimi = loom
print("Pikim nimi on: " + pikimNimi)
