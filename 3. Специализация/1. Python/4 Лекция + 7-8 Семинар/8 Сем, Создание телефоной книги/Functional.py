"""
# 55.  Создать телефонный справочник с возможностью импорта и экспорта данных в формате .txt.
# Фамилия, имя, отчество, номер телефона - данные, которые должны находиться в файле.

# 1. Программа должна выводить данные
# 2. Программа должна сохранять данные в текстовом файле
# 3. Поиск по фамилии
from func import *


privet()

# 1 - Интерфейс
# 2 - работа с файлом
# 3 - алгоритм


# 1 - добавление контакта
# 2 - вывод всех
# 3 - поиск по фамилии
# 4 - выход

"""

def create(path):
    try:
        file = open(path, 'r')
    except IOError:
        print('Создан новый справочник -> phone_book.txt ')
        file = open(path, 'w') 
    finally:
        file.close()


# 1 - добавление контакта
def add_cont(file_name, stroka): 
    data = open(file_name, 'a')
    data.write(stroka + "\n")
    data.close 

# 2 - вывод всех
def show_all(file_name):
    data = open(file_name, "r")
    count = 0
    for line in data:
        count+=1
        print(f"\n{count}. {line} \n")
    data.close()

# 3 - поиск по фамилии
def search(file_name, stroka):
    data = open(file_name, "r")
    for line in stroka:
        if stroka in line:
            print(data)
            break
    data.close()
