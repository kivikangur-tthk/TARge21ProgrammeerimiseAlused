from turtle import *
 
def ruut(pikkus):                # Defineerime funktsiooni nimega ruut
    i = 0
    while (i < 4):
        forward(pikkus)
        left(90)
        i = i + 1

for i in range(45,360,45):
    ruut(i)                     # Kutsume funktsiooni ruut välja. Kilpkonn joonistab ruudu küljega 100 pikslit
    right(i)                  # Pöörame paremale 45°                     # Kutsume uuesti funktsiooni ruut välja
 
exitonclick()