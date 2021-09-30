from time import sleep

keel = int(input("1) Eesti 2) English 3) Deutsche "))

if keel == 2:
    failinimi = "eng.txt"
elif keel == 3:
    failinimi = "ger.txt"
else:
    failinimi = "est.txt"

readfailist = open(failinimi, encoding="UTF-8")
read = []  # ilma reavahetusteta ridade list
for rida in readfailist:  # reakaupa listist readfailist
    read = read + [rida.strip("\n")]  # ilma reavahetuseta rida lisatakse listi
    # või read.append(rida.strip("\n"))
readfailist.close()  # faili ei lähe enam vaja

sisestatud_pin = ""
katseid = 3
while sisestatud_pin != "1234" and katseid > 0:
    print(read[0])
    print(read[1] + str(katseid) + read[2])
    katseid -= 1
    sisestatud_pin = input()
if sisestatud_pin == "1234":
    print(read[3])
else:
    print(read[4])
    i = 10
    while i > 0:
        print(i)
        i -= 1
        sleep(1)
