# Koosta programm, mis küsib kasutajalt nime ja tervitab teda nimeliselt 5 korda ja lisab ka tervituse järjekorranumber.
#
# Palun sisesta oma nimi:
# >> Siim
# Ole tervitatud, Siim, 1. korda.
# Ole tervitatud, Siim, 2. korda.
# Ole tervitatud, Siim, 3. korda.
# Ole tervitatud, Siim, 4. korda.
# Ole tervitatud, Siim, 5. korda.

nimi = input("Sisesta oma nimi: ")
for i in range(1, 6):
    print("Ole tervitatud, " + nimi + ", " + str(i) + ". korda.")
print(i)
