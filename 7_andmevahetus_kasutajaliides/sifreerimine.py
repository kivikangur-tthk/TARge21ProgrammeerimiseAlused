print(ord("A"))
print(ord("a"))
print(ord("ä"))
print(ord("õ"))
print(ord(" "))
print(chr(15230))


def kodeeri(sümbol, nihe):
    return chr(ord(sümbol) + nihe)


def šifreeri(failinimi, nihe):
    f = open(failinimi, "w")
    kiri = input("Sisesta lause ")
    for sümbol in kiri:
        f.write(kodeeri(sümbol, nihe))
    f.close()


def dekodeeri(sümbol, nihe):
    return chr(ord(sümbol) - nihe)


def dešifreeri(failinimi, nihe):
    f = open(failinimi, "r")
    while True:
        sümbol = f.read(1)  # loetakse üks sümbol
        if sümbol == "":  # kui sümboleid enam pole
            break  # tsükkel katkestatakse
        print(dekodeeri(sümbol, nihe), end="")
    f.close()


failinimi = input("Faili nimi? ")
nihe = int(input("Nihe? "))
if input("Šifreeri?").lower() == "jah":
    šifreeri(failinimi, nihe)
else:
    dešifreeri(failinimi, nihe)
