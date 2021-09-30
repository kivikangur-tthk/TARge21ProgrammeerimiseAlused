from tkinter import *

suurus = 4
raam = Tk()
raam.title("Setopmaa lipp")
tahvel = Canvas(raam, width=135 * suurus, height=75 * suurus, background="white")


def joone_ruut(x1, y1, x2, y2):
    tahvel.create_rectangle(x1, y1, x2, y2, fill="white", width=0)
    kesk_x = (x1 + x2) / 2
    kesk_y = (y1 + y2) / 2
    tahvel.create_rectangle(x1, y1, kesk_x, kesk_y, fill="red", width=0)
    tahvel.create_rectangle(x2, y2, kesk_x, kesk_y, fill="blue", width=0)


def topelt_joon(x, y, pikkus, suund):
    for i in range(pikkus):
        if suund == "N":
            joone_ruut(x, y - i * suurus * 2, x - suurus * 2, y - i * suurus * 2 - suurus * 2)
        if suund == "S":
            joone_ruut(x, y + i * suurus * 2, x + suurus * 2, y + i * suurus * 2 + suurus * 2)
        if suund == "E":
            joone_ruut(x + i * suurus * 2, y, x + i * suurus * 2 + suurus * 2, y - suurus * 2)
        if suund == "W":
            joone_ruut(x - i * suurus * 2, y, x - i * suurus * 2 - suurus * 2, y + suurus * 2)


def plus(x1, y1, toon):
    tahvel.create_rectangle(x1, y1 + suurus, x1 + 3 * suurus, y1 + 2 * suurus, fill=toon, width=0)
    tahvel.create_rectangle(x1 + suurus, y1, x1 + 2 * suurus, y1 + 3 * suurus, fill=toon, width=0)


def ruut(x1, y1, ees, taga):
    tahvel.create_rectangle(x1, y1, x1 + 15 * suurus, y1 + 15 * suurus, fill=taga, width=0)
    # tsüklimuutuja
    i = 0
    kõrgus = y1 + 15 * suurus
    while i < 14:
        tahvel.create_rectangle(x1 + i * suurus, y1 + i * suurus, x1 + i * suurus + 2 * suurus,
                                y1 + i * suurus + 2 * suurus, fill=ees, width=0)
        tahvel.create_rectangle(x1 + i * suurus, kõrgus - i * suurus - 2 * suurus,
                                x1 + i * suurus + 2 * suurus, kõrgus - i * suurus, fill=ees, width=0)
        i += 1
    tahvel.create_rectangle(x1 + 5 * suurus, y1 + 5 * suurus, x1 + 5 * suurus + 2 * suurus,
                            y1 + 5 * suurus + 2 * suurus, fill=taga, width=0)
    tahvel.create_rectangle(x1 + 8 * suurus, y1 + 8 * suurus, x1 + 8 * suurus + 2 * suurus,
                            y1 + 8 * suurus + 2 * suurus, fill=taga, width=0)
    tahvel.create_rectangle(x1 + 5 * suurus, kõrgus - 5 * suurus - 2 * suurus,
                            x1 + 5 * suurus + 2 * suurus, kõrgus - 5 * suurus, fill=taga, width=0)
    tahvel.create_rectangle(x1 + 8 * suurus, kõrgus - 8 * suurus - 2 * suurus,
                            x1 + 8 * suurus + 2 * suurus, kõrgus - 8 * suurus, fill=taga, width=0)
    plus(x1 + 6 * suurus, y1 + suurus, ees)
    plus(x1 + 6 * suurus, y1 + 11 * suurus, ees)
    plus(x1 + suurus, y1 + 6 * suurus, ees)
    plus(x1 + 11 * suurus, y1 + 6 * suurus, ees)


# for i in range(0, 550, suurus * 2):
#     for j in range(0, 300, suurus):
#         tahvel.create_rectangle(i + j % (suurus * 2), j, i + suurus + j % (suurus * 2), j + suurus, fill="red",
#                                 width=0)
# tahvel.create_rectangle(0, 0, 30 * suurus, 30 * suurus, fill="white", width=0)
# tahvel.create_rectangle(0, 45 * suurus, 30 * suurus, 75 * suurus, fill="white", width=0)
# tahvel.create_rectangle(45 * suurus, 0, 140 * suurus, 30 * suurus, fill="white", width=0)
# tahvel.create_rectangle(45 * suurus, 45 * suurus, 140 * suurus, 75 * suurus, fill="white", width=0)

for i in range(5):
    if i % 2 == 0:
        ruut(30 * suurus, i * 15 * suurus, "white", "red")
    else:
        ruut(30 * suurus, i * 15 * suurus, "red", "white")
for i in range(9):
    if i % 2 == 0:
        ruut(i * 15 * suurus, 30 * suurus, "white", "red")
    else:
        ruut(i * 15 * suurus, 30 * suurus, "red", "white")
topelt_joon(45 * suurus, 75 * suurus, 16, "N")
topelt_joon(45 * suurus, 33 * suurus, 17, "N")
topelt_joon(30 * suurus, 0, 16, "S")
topelt_joon(30 * suurus, 42 * suurus, 17, "S")
topelt_joon(0, 45 * suurus, 16, "E")
topelt_joon(42 * suurus, 45 * suurus, 90, "E")
topelt_joon(135 * suurus, 30 * suurus, 45, "W")
topelt_joon(31 * suurus, 30 * suurus, 30, "W")
tahvel.pack()
raam.mainloop()
