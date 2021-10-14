"""
Loo funktsioon, mis saab argumendina ette täisarvu ja
trükib ekraanile sama suure arvu tärne.
Koosta programm, mis kutsub seda funktsiooni välja 30 korda
juhuslike positiivsete täisarvudega, mis on väiksemad kui 20.
Näiteks:
************
*********
**********************
*******
[...]
Täienda programmi:

Iga rea ette kirjutatakse arv, mitu sümbolit on reas.
Funktsiooni kutsutakse välja mitte 30 korda,
 vaid juhuslik arv kordi vahemikus 20 kuni 40.
Funktsioon saab ette ühe argumendi asemel kaks argumenti:
 lisaks arvule ka sümboli, mida trükitakse.
"""
from random import randint


def trükiTärnid(kogus, sümbol):
    print(kogus, sümbol * kogus)


for i in range(randint(20, 40)):
    trükiTärnid(randint(1, 20), chr(randint(32, 126)))
