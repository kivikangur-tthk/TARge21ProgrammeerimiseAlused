from random import randint

arv = randint(1, 19)  # Juhuslik täisarv
print("Mõtlen ühele 20-st väiksemale naturaalarvule. Arva ära!")
arvamus = int(input())
arvamisi = 1
while arvamus != arv:
    print("Oled arvanud " + str(arvamisi) + " korda")
    if arv > arvamus:
        print("Minu arv on suurem!")
    else:
        print("Minu arv on väiksem!")
    print("Arva veel!")
    arvamus = int(input())
    arvamisi += 1
print("Õige! Tubli! Said pihta " + str(arvamisi) + ". korral.")
