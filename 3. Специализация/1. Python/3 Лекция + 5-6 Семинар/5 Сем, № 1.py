# import lect
# print(max1(1,5))


# Задача 26. Напишите программу, которая на вход 
# принимает два числа А и В, и возводит число А
# в целую степень В с помощью рекурсии.

a = int(input("Введите первое число: "))
b = int(input("Введите второе число: "))
c = 1

def degree(a, b, c):
    if b != 0: 
        c *=  a 
        b -= 1
    else: return c
    return degree(a, b, c)

print(degree(a, b, c))




# Еще вариант 
def my_power(a,b):
    if b ==0:
        return 1
    else:
        return a* my_power(a,b-1)

a= int(input())
b= int(input())
print(my_power(a,b))