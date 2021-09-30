from tkinter import *

raam = Tk()
raam.title("Haapsalu lipp")
# loome tahvli laiusega 600px ja kõrgusega 300 px
tahvel = Canvas(raam, width=600, height=300)
# ühe joone kõrgus
kõrgus = 100
# tsüklimuutuja
i = 0
while i < 3:
    # esimene ja kolmas joon
    if i == 0 or i == 2:
        # if i % 2 == 0:
        # sinine väike ristkülik
        tahvel.create_rectangle(0, i * kõrgus, 200, (i + 1) * kõrgus, fill="blue", outline="blue")
        # valge suur ristkülik
        tahvel.create_rectangle(200, i * kõrgus, 600, (i + 1) * kõrgus, fill="white", outline="white")
    # teine joon
    else:
        # valge väike ristkülik
        tahvel.create_rectangle(0, i * kõrgus, 200, (i + 1) * kõrgus, fill="white", outline="white")
        # sinine suur ristkülik
        tahvel.create_rectangle(200, i * kõrgus, 600, (i + 1) * kõrgus, fill="blue", outline="blue")
    # tsüklimuutuja suurendamine
    i += 1
# paigutame tahvli raami ja teeme nähtavaks
tahvel.pack()
# siseneme põhitsüklisse
raam.mainloop()
