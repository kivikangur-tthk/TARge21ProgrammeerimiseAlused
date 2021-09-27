from random import randint

valik = input("Kas soovite istekohta ise valida(\"ise\") või loosida (\"loos\")? ")
if valik.lower() == "ise":
    iste = "Aknakoht" if input(
        "Kas soovite istuda akna ääred (\"aken\") või mitte (\"muu\")? ") == "aken" else "Vahekäigukoht"
    print("Valisite ise. " + iste)
else:
    iste = "Aknakoht" if randint(1, 3) == 1 else "Vahekäigukoht"
    print("Istekoht loositi. " + iste)
