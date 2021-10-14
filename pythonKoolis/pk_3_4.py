from random import randint

juhuslikArv = randint(1, 20)
arvamisi = 0
while True:
    arvatudArv = int(input("Sisesta täisarv 1-20: "))
    arvamisi += 1
    if arvatudArv == juhuslikArv:
        print("VÕITSID!")
        break
    elif arvamisi == 5:
        print("KAOTASID! Õige arv oli:", juhuslikArv)
        break
    elif arvatudArv > juhuslikArv:
        print("Liiga suur, proovi uuesti.")
    else:
        print("Liiga väike, proovi uuesti.")
