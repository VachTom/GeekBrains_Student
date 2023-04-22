slovar = {"1": "Вачик", "2": "Нанэ"}
# print(slovar)

slovar["3"] = "Любовь Вечно"  
# print(slovar)

# for i in slovar:
#    print(i, slovar[i]) # 1 - ключи, 2 значение ключа. Поиск всегда происходит через ключ. Нельзя найти ключ по значению, только значение по ключу

for (key, value) in slovar.items():
    print(key, value)
    
# for (key, value) in slovar.items():
#     if key == 1:
#         slovar[key]
# print(slovar)





# spisok = [1, 5, 6, 15, 65, 99, 150]
# spisok2 = spisok[:3] + spisok[5:]
# print(spisok2)
# print(spisok[5:2:-1]) # обратный эффект




# 17. Дан список чисел. Определите, сколько в нем встречается различных чисел.

""" list_1 = [1, 2, 3, 1, 1, 5, 10, 20, 20, 30]
print(list_1)
print(len(list_1))

b = []
for i in list_1:
    if (not i in b):
        b.append(i)
print(b)
print(len(b))

print(len(set(list_1))) # еще решение в одну строку
 """

# Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность
# (сдвиг - циклический) на K элементов вправо, K – положительное число.

# [1, 2, 3, 4, 5, 6, 7, 8, 9]
# 3
# 7 8 9 1 2 3 4 5 6

# arr = [1, 2, 3, 4, 5, 6, 7, 8, 9]
# k = 5
# arr2 = arr[-k:] + arr[:-k] 

# print(arr)
# print(arr2)