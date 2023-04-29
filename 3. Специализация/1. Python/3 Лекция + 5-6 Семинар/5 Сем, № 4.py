""" Хакер Василий получил доступ к классному журналу и хочет заменить все свои минимальные оценки на максимальные.
Напишите программу, которая заменяет оценки Василия, но наоборот: все максимальные – на минимальные.

1 5 2 1 5 4
1 1 2 1 1 4 """


import random

journal = [i for i in range(1,10) journal.append(int(random.randint(1,5)))]



for i in range(1,10):
    temp = int(random.randint(1,5))
    journal.append(temp)

print(journal)
