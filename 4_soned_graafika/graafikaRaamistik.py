from tkinter import *

raam = Tk()
raam.title("Joontega tahvel")

tahvel = Canvas(raam, width=600, background="red", height=400)
# üks horisontaalne sirglõik
tahvel.create_line(50, 50, 100, 50)

# horisontaalne sirglõik ja vertikaalne sirglõik
tahvel.create_line(50, 150, 100, 150, 100, 200)

# sirglõik paksusega 4px
tahvel.create_line(50, 100, 100, 250, width=4)

# rohelist värvi nool paksusega 4px
tahvel.create_line(350, 50, 350, 100, width=4, fill="green", arrow=LAST)

# ruut - valge
tahvel.create_line(150, 150, 200, 150, 200, 200, 150, 200, 150, 150, fill="white")

# seest tühi ristkülik (ruut) mustade servadega
tahvel.create_rectangle(150, 50, 200, 100)

# seest tühi ristkülik kollaste servadega, mille paksus on 2px
tahvel.create_rectangle(150, 150, 200, 200, width=2, outline="yellow")

# mustade servadega roheline ristkülik
tahvel.create_rectangle(150, 250, 200, 300, fill="green")

# roosade servadega valge ristkülik
tahvel.create_rectangle(250, 250, 300, 300, fill="white", outline="pink", width=4)

# mustade servadega punane kolmnurk
tahvel.create_polygon(150, 350, 150, 400, 200, 375, fill="red", outline="black")

# roheliste servadega punane ovaal(ring)
tahvel.create_oval(10, 10, 100, 100, fill="blue", outline="green")

# valge värvi tekst "Tere!"
tahvel.create_text(50, 50, text="Tere!", fill="white")

# sinist värvi teksti "Tere!" alumine vasak punkt on (50, 50)
tahvel.create_text(50, 50, text="Tere!", anchor=SW, fill="yellow")

tahvel.pack()

raam.mainloop()
