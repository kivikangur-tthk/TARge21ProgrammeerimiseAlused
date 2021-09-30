nädalapäevad = ["esmaspäev", "teisipäev", "kolmapäev", "neljapäev", "reede", "laupäev", "pühapäev"]
print(nädalapäevad)

nädalapäevi = len(nädalapäevad)
print('Järjendis on ' + str(nädalapäevi) + ' elementi')

if "palgapäev" in nädalapäevad:
    print("Palgapäev on järjendis")
else:
    print("Palgapäev ei ole järjendis")

print(nädalapäevad[0])
print(nädalapäevad[-1])

linn = "Tartu"
print(linn[2])
print(nädalapäevad[1][1])

a = ['A', 'B', 'C', 'D', 'E']
print(a[0:2])
print(a[:2])
print(a[2:5])
print(a[2:])
print(a[-2:])

sõne1 = 'Tartu'
print(sõne1[1:4])
sõne2 = sõne1
print(sõne2[-2:])
print("Väike-Maarja"[4:9])

a = [5, 8]
a.append(7)
print(a)
b = [5, 8]
b += [7]
print(b)
print(sorted(nädalapäevad))
print(min(nädalapäevad))
print(max(nädalapäevad))
