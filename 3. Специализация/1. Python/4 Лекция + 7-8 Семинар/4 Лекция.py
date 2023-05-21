
# Лямбда 

""" 1. В списке хранятся числа. Нужно выбрать только чётные числа и составить список пар 
        (число; квадрат числа).
        Пример: 1 2 3 5 8 15 23 38
        Получить: [(2, 4), (8, 64), (38, 1444)] """

# 1 Способ
import random

# n = int(input("Введите размер массива: "))
# mas = [random.randint(0,100) for i in range(1, n)]
# result = [(i,i**2) for i in mas if i % 2 == 0]

# print(f"Массив: {mas}")
# print(f"Результат: {result}")

# 2 Способ
""" 
def select(f, col):
    return [f(x) for x in col]
def where(f, col):
    return [x for x in col if f(x)]

mas = [1, 2, 3, 5, 8, 15, 23, 38]
res = select(int, mas)
print(res)
res = where(lambda x: x % 2 == 0, res)
print(res)
res = list(select(lambda x:(x,x**2), res))
print(res)
 """




# Фунция map + лямбда
list_1 = [x for x in range(1, 21)]
print(f"{list_1}")

list_1 = list(map(lambda x: x + 10, list_1))
print(f"{list_1}")


 