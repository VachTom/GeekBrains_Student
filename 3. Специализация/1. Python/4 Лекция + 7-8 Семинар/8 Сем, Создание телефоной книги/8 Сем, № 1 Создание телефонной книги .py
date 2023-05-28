# with open("C:\\Users\\wrest\\OneDrive\\Рабочий стол\\Обучение\\GeekBrains\\3. Специализация\\1. Python\\4 Лекция + 7-8 Семинар\\ppp\\test.txt", 'a') as data:
#     data.write("dfdsg\n") # Запись построчно \n в наш файл
# data.close

# # +1 вариант записи
# data2 = open("C:\\Users\\wrest\\OneDrive\\Рабочий стол\\Обучение\\GeekBrains\\3. Специализация\\1. Python\\4 Лекция + 7-8 Семинар\\ppp\\test.txt", 'r') # Чтение записи 
# for i in data2:
#     print(i)


spis = ["123", "324"]
data = open("C:\\Users\\wrest\\OneDrive\\Рабочий стол\\Обучение\\GeekBrains\\3. Специализация\\1. Python\\4 Лекция + 7-8 Семинар\\ppp\\test.txt", 'w') # Чтение записи 
data.writelines(spis) # Запись всего списка в наш файл
data.close()