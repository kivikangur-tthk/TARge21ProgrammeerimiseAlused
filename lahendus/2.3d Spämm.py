suurus = float(input("Sisestage kirja suurus: "))
teema = input("Sisestage kirja teema pealkiri: ")
fail = input("Kas kirjaga on kaasas fail? ")
if teema == "" or fail == "jah" and suurus > 1:
    print("Kiri on spämm")
else:
    print("Kiri ei ole spämm")
