"""
Loo funktsioon, mis trükib sellele argumendina ette antud pealinna nime alusel lause
"Üks Euroopa pealinnadest on LINNA_NIMI".
Kasutades loodud Euroopa pealinnade järjendit, kutsu seda funktsiooni välja iga pealinna puhul.
"""
pealinnad = ["Tallinn", "Riia", "Helsingi", "Stockholm"]


def kuvaLinnaNimi(pealinn):
    print("Üks Euroopa pealinnadest on " + pealinn)


for linn in pealinnad:
    kuvaLinnaNimi(linn)
