from turtle import *
def joonistaHulknurk(nurkadeKogus,pikkus):    
    i = 0
    nurk = 360 / nurkadeKogus         # Arvutatakse kilpkonna pööramise nurga suurus
    while (i < nurkadeKogus):
        forward(pikkus)
        left(nurk)
        i = i + 1

fillcolor("violet")
begin_fill()
joonistaHulknurk(100,10)
end_fill()
fillcolor("yellow")
begin_fill()
joonistaHulknurk(10,100)
end_fill()
fillcolor("green")
begin_fill()
joonistaHulknurk(5,100)
end_fill()
fillcolor("red")
begin_fill()
joonistaHulknurk(3,100)
end_fill()


exitonclick()