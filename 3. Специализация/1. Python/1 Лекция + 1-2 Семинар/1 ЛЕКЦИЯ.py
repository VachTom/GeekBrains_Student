# https://gbcdn.mrgcdn.ru/uploads/asset/3681957/attachment/2a0236333afe4d0de6614dd39978f004.pdf
# https://gbcdn.mrgcdn.ru/uploads/asset/4930829/attachment/705a75044faee00f575ad5ae6d0c1f80.pdf


# Формат цифры после точки сколько знаков показываешь 
a = 5.45687
b = 8.4566445687
print(round(a*b,3))


"""         Range
● Range выдает значения из диапазона с шагом 1.
● Если указано только одно число — от 0 до заданного числа.
● Если нужен другой шаг, третьим аргументов можно задать приращение."""

r = range(5) # 0 1 2 3 4
r = range(2, 5) # 2 3 4
r = range(-5, 0) # ----
r = range(1, 10, 2) # 1 3 5 7
r = range(100, 0, -20) # 100 80 60 40 20
r = range(100, 0, -20) # range(100, 0, -20)

for i in r:
    print(i) # 100 80 60 40 20


    

spisok = [1, 5, 6, 15, 65, 99, 150]
spisok2 = spisok[:3] + spisok[5:]
print(spisok2)
print(spisok[5:2:-1]) # обратный эффект