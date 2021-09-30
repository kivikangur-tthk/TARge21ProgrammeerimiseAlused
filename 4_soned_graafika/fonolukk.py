# Impordime kõik vajalikud teegid
from tkinter import *
from tkinter import ttk

# Loome raami ja paneme raamile pealkirja
raam = Tk()
raam.title("Fonolukk")

# Fonoluku ekraani osa
kood = ttk.Entry(raam).grid(row=0, column=0, columnspan=3, rowspan=1, sticky=(N, W, E), padx=5, pady=5)

# Lisame fonolukule numbrid
rida = 1
veerg = 0
arv_nupul = 1
while arv_nupul < 10:
    # Lisame nupu
    ttk.Button(raam, text=str(arv_nupul)).grid(row=rida, column=veerg, padx=5, pady=5)
    # Kui arv_nupul jagub 3-ga, siis paneme järgmise arvu uude ritta ja nullime veeru väärtuse
    if arv_nupul % 3 == 0:
        rida += 1
        veerg = 0
    # Kui arv_nupul ei jagu 3-ga, siis suurendame veeru väärtust.
    else:
        veerg += 1

    # Suurendame arvu väärtust
    arv_nupul += 1

# Lisame ka teised fonolukul esinevad sümbolid
ttk.Button(raam, text="*").grid(row=4, column=0, padx=5, pady=5)
ttk.Button(raam, text="0").grid(row=4, column=1, padx=5, pady=5)
ttk.Button(raam, text="#").grid(row=4, column=2, padx=5, pady=5)

# Kuvame ekraanile
raam.mainloop()
