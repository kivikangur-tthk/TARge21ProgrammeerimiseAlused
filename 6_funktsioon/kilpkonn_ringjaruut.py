from turtle import *
 
def ruut(n):               # Defineerime funktsiooni ruudu joonistamiseks
    i = 0
    while (i < 4):
        fd(n)
        lt(90)
        i = i + 1
 
pencolor("#32CD32")        # Kilpkonn muudab pliiatsi värvi laimiroheliseks
fillcolor("red")           # Kilpkonn muudab täitevärvi punaseks
begin_fill()               # Kilpkonn alustab ringi värvimist
circle(100)                # Kilpkonn joonistab ringi raadiusega 100 pikslit
end_fill()                 # Kilpkonn lõpetab ringi värvimise
 
up()                       # Pliiats üles
fd(300)                    # Kilpkonn liigub edasi 300 pikslit
lt(90)                     # Kilpkonn pöörab 90° vasakule
fd(50)
down()                     # Pliiats alla
 
pencolor("red")            # Kilpkonn muudab pliiatsi värvi punaseks
fillcolor("#32CD32")       # Kilpkonn muudab täitevärvi laimiroheliseks
begin_fill()
ruut(100)                  # Kilpkonn joonistab ruudu küljega 100 pikslit
end_fill()
 
bgcolor("pale turquoise")  # Muudame taustavärvi helesiniseks
 
exitonclick()