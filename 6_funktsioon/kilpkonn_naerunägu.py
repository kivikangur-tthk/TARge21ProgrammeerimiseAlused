from turtle import *
 
def silm():                # Defineerime funktsiooni silmade joonistamiseks     
    pencolor("#000000")
    fillcolor("#FFFFFF")
    begin_fill()
    circle(25)
    end_fill()
 
pencolor("#000000")        # Pea
fillcolor("#FFFF00")  
begin_fill()
circle(100)                 
end_fill()
 
up()                              
bk(45)
lt(90)
fd(100)
rt(90)
down()
 
silm()                     # Vasak silm
 
up()                             
fd(90)
down()
 
silm()                     # Parem silm
 
up()                       # Suu
bk(95)
rt(90)
fd(30)
down()
circle(50,180)             # Pool ringjoonest
bgcolor("#AFEEEE")
 
exitonclick()