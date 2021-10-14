from easygui import *  # EasyGui kasutamiseks importida

msgbox("Minu esimene graafiline kasutajaliides!!")  # teateaken

nupud = ["lihtne", "ok", "keeruline"]
vajutati = buttonbox("Programmeerimine on ", choices=nupud)
msgbox("Te arvate, et programmeerimine on " + vajutati + "!")
