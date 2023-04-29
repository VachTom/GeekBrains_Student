# Дано натурально число N и последовательность из N
# элементов. Требуется вывести эту последовательность 
# в обратном порядке.



n = int(input("Введите целое число: "))
def rotate(n):
    if n == 1: return n 
    else: 
        print(n, end=" ")
        less = rotate(n-1)
    return less

print(rotate(n))


