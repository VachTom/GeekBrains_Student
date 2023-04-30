# 1                                 Рекурсия. Числа Фибаначи
# def fib(n):
#     if n in [1, 2]: return 1
#     else: return fib(n-1) + fib(n-2)
# list1 = list()
# for i in range(1, 10):
#     list1.append(fib(i))
# print(list1)


# 2
# С помощью генератора списка Фиббаначи
# def fib(n):
#     if n in [1, 2]: return 1 
#     else: return fib(n-1) + fib(n-2)
# list1 = [fib(i) for i in range(1, 10)]
# print(list1)


# 3
# def fib(n):
#     if n <=2: return 1
#     else: return fib(n-1) + fib(n-2)
# printFib = [fib(i) for i in range(1,10)]
# print(printFib)


# 4
# n = int(input("Введите число Факториала: "))
# def fib(n):
#     if n in [1, 2]: return 1
#     else: 
#         return fib(n-1) + fib(n-2)
# list1 = [fib(i) for i in range(1,10)]
# print(list1)




#                              Быстрая сортировка
# def quick_sort(array):
#     if len(array) <= 1:
#         return array
#     else:
#         pivot = array[0]
#     less = [i for i in array[1:] if i <= pivot]
#     greater = [i for i in array[1:] if i > pivot]
#     return quick_sort(less) + [pivot] + quick_sort(greater)

# print(quick_sort([14, 15, 10, 55, 22, 19, 7, 5, 9]))


# def sort(array):
#     if len(array) <= 1: return array

#     point = array[0]
#     less = [i for i in array[1:] if i <= point]
#     greater = [i for i in array[1:] if i > point]
#     return sort(less) + [point] + sort(greater) 

# print(sort([2, 25, 4, 45, 7, 5]))


# def sortik(array):
#     if len(array) <= 1: return array
#     pointik = array[0]
#     lesss1 = [i for i in array[1:] if i <= pointik]
#     lesss2 = [i for i in array[1:] if i > pointik]
#     return sortik(lesss1) + [pointik] + sortik(lesss2)
# print(sortik([4, 49, 44, 16, 25, 25, 19]))


import random

n = int(input("Введите размер массива: "))
array1 = list()
for i in range(0,n):
    array1.append(random.randint(1,50))



def sort(array):
    if len(array) == 1: return 1
    else:
        count = [0]
        left = [i for i in array[1:] if i <= count]
        rigth = [i for i in array[:1] if i > count]    
    return sort(left) + [count] + sort(rigth)
    


print(array1)
print(sort([array]))