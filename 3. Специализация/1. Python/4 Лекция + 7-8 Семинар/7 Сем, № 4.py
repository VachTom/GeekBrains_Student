""" Напишиет программу, которая принимает на вход вещественное 
число и показывает сумму его цифр 

123 --> 6 
1.23 --> 6 
"""
word = input("Введите слово: ")
word = word.replace(",","").replace(".","")

print(word)
res_word = list(map(lambda x: x, word)) # список каждого символа 
print(res_word)

res_word = sum(map(lambda x: int(x), word)) # из списка в сумму каждого числа
print(res_word)