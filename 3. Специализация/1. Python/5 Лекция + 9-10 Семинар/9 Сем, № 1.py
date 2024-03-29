# Задача с Винни-Пухом 
""" Задача 34:  Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. 
Поскольку разобраться в его кричалках не настолько просто, 
насколько легко он их придумывает, Вам стоит написать программу. 
Винни-Пух считает, что ритм есть, если число слогов (т.е. число гласных букв) 
в каждой фразе стихотворения одинаковое. Фраза может состоять из одного слова, 
если во фразе несколько слов, то они разделяются дефисами. 
Фразы отделяются друг от друга пробелами. Стихотворение  Винни-Пух вбивает 
в программу с клавиатуры. В ответе напишите “Парам пам-пам”, 
если с ритмом все в порядке и “Пам парам”, если с ритмом все не в порядке

*Пример:*

**Ввод:** пара-ра-рам рам-пам-папам па-ра-па-да    
    **Вывод:** Парам пам-пам  
 """


stroka = "пара-ра-рам рам-пам-папам па-ра-па-да"
vovles = ["а", "е", "ё", "ю", "я", "у", "о", "ы", "и", "э"]
vovlesplit = stroka.split()
print(vovlesplit)

if len(stroka) < 2:
    print("Количество фраз должно быть больше одной ")
else:
    countVovles = []
    for i in vovlesplit:
        countVovles.append(len([x for x in i if x.lower() in vovles]))
print(countVovles)

# Либо пройтись через set(множества) он убирает все повторяющие и оставляет одно уникальное код: set(countVovles) == 1: 
if countVovles.count(countVovles[0]) == len(countVovles):
    print("Парам пам-пам")
    
else:
    print("Пам парам")
