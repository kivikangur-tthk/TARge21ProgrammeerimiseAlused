from tkinter import *
from random import *
 
def joonista_tase(ülatipp_x, ülatipp_y, laius, värv):
    tahvel.create_polygon(ülatipp_x, ülatipp_y, ülatipp_x + laius/2, ülatipp_y + laius/2, ülatipp_x - laius/2,  ülatipp_y + laius/2, fill=värv, outline=värv)
 
def joonista_kuusk(ladva_x, ladva_y, laius, tasemeid, värv="green"):
    for tase in range(tasemeid):
        joonista_tase(ladva_x, ladva_y + tase * laius/3, laius, värv)
 
def joonista_mets(kuuskede_arv):
    for tase in range(kuuskede_arv):
        joonista_kuusk(randint(1, 600), randint(1, 200), randint(10, 30), randint(3, 5))
 
raam = Tk()
# nimeks Kuusik
raam.title("Kuusik")
# loome tahvli laiusega 600px ja kõrgusega 300 px
tahvel = Canvas(raam, width=600, height=300)
 
joonista_mets(50)
joonista_kuusk(200, 50, 40, 4, "red")
 
# paigutame tahvli raami ja teeme nähtavaks
tahvel.pack()
# siseneme põhitsüklisse
raam.mainloop()