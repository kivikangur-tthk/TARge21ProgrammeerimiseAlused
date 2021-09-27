# Koosta programm, mis küsib kasutajalt nime ja vanust
# ja väljastab ekraanile nimelise tervituse koos tekstiga,
# mis ütleb, kas tegemist on 7-18-aastase inimesega.
nimi = input("Sisesta oma nimi: ")
vanus = float(input("Sisesta oma vanus aastates: "))
if vanus >= 7 and vanus <= 18:
    print("Tere", nimi, "oled 7-18 aastane.")
else:
    print("Tere", nimi, "sa ei ole 7-18 aastane.")
