""" Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[N].
Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

Ввод: 5
Ввод: 3 2 3 7 5
Ввод: 3
-> 2        """

n = int(input("Введите кол-во элементов в массиве: ")) + 1
arr = []

for i in range(1, n):
    temp = int(input())
    arr.append(temp)
print(arr)

count = 0

countNumber = int(input(
    "Введите число по которому будет обрабатываться поиск повторяющих значений: "))
# for j in range(len(arr)):
#     if arr[j] == countNumber:
#         count += 1
# print(f"Повторы: {count}")


# Можно сделать цикл for иначе:
for i in arr: # 
    if i == countNumber:
        count+=1
print(count)


print(arr.count(countNumber)) # Вместо последнего цикла for


