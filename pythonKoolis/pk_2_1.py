# Koosta programm, mis küsib kasutajalt ristküliku lähiskülgede pikkused
# ning väljastab ekraanile ristküliku ümbermõõdu ja pindala.
pikkus = int(input("Sisesta ristküliku pikkus täisarvuna (cm): "))
laius = int(input("Sisesta ristküliku laius täisarvuna (cm): "))
print("Ristküliku ümbermõõt on", 2 * (pikkus + laius))
print("Ristküliku pindala on", pikkus * laius, "cm\u00b2")
