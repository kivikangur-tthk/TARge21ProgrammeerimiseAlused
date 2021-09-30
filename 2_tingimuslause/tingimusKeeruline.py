kartul_olemas = True
makaron_olemas = True
salatikaste_olemas = False
print((kartul_olemas or makaron_olemas) and salatikaste_olemas)

kasSajab = True
onRatas = True
temp = int(input("Sisesta temperatuur (täisarvuna): "))

if onRatas and (not kasSajab or (25 > temp and temp > 15)):
    print("Saab trenni teha")
else:
    print("Ei saa trenni teha :(")

punktid = int(input("Sisesta punktide arv"))

if punktid > 90:
    print("Hinne A")
elif punktid > 80:
    print("Hinne B")
elif punktid > 70:
    print("Hinne C")
elif punktid > 60:
    print("Hinne D")
elif punktid > 50:
    print("Hinne E")
else:
    print("Hinne F")
