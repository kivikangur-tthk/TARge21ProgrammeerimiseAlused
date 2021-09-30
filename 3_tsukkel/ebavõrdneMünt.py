from random import randint

tõenäosus = 73
i = 0
kirju = 0
kulle = 0
while i < 10000:
    if randint(1, 100) <= tõenäosus:
        # print("kiri")
        kirju += 1
    if randint(1, 2) == 1:
        kulle += 1
    i += 1
print("Kiri tuli", kirju, "korda")
print("Kull tuli", kulle, "korda")
