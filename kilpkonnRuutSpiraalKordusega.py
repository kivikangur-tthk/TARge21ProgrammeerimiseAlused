from turtle import *

speed(0)
summa = 0
i = 1  # Muutuja i väärtus on esialgu 0
while i <= 200:  # Kilpkonn joonistab tsükli abil ruudu. Tsükli keha läbitakse neli korda.
    nihe = 10 + 3 * i
    forward(nihe)
    left(90)
    i = i + 1  # Muutuja i väärtust suurendatakse ühe võrra
    summa += nihe
print("Summa:", summa)
exitonclick()
