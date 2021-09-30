sisend = -1
while sisend <= 0 or sisend > 7:
    sisend = int(input("Sisesta pöialpoiste arv (1-7): "))
    if sisend % 2 == 0:
        print("Sisestasid paarisarvu")
    else:
        print("Sisestasid paaritu arvu")
print("Sisestasid: ", sisend)
