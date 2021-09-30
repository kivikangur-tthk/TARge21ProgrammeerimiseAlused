from tkinter import *

raam = Tk()
raam.title("Tahvel")
tahvel = Canvas(raam, width=400, height=400, background="white")
tahvel.grid()

# pildi kuvamisel on vaja kõigepealt laadida pilt ja panna see siis tahvlile
kuusk = PhotoImage(file="kuusk.gif")
img = tahvel.create_image(250, 80, image=kuusk)

# activeimage määrab pildi, mida näidatakse, kui hiirekursor on pildi kohal
# anchor näitab, mille järgi pilt paigutatakse (antud juhul ülemise-vasaku nurga järgi)
lill = PhotoImage(file="lill.gif")
img = tahvel.create_image(50, 200, image=lill, activeimage=lill, anchor=NW)

raam.mainloop()
