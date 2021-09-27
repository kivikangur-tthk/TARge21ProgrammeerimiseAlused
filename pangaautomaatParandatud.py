from time import sleep

sisestatud_pin = ""
katseid = 3
while sisestatud_pin != "1234" and katseid > 0:
    print("Jäänud on " + str(katseid) + " katset.")
    sisestatud_pin = input("Sisesta PIN-kood:")
    katseid -= 1
if sisestatud_pin == "1234":
    print("Sisenesid pangaautomaati!")
else:
    print("Katsete arv ületatud! Turvatöötaja kutsutakse 10 sekundi pärast!")
    i = 10
    while i > 0:
        print(i)
        i -= 1
        sleep(1)
    print("Turvatöötaja kutsutud!")
