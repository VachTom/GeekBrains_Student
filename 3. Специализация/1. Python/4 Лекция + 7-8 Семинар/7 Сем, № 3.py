""" Дан список, вывести отдельно буквы и цифры, пользуясь filter 
Пример: [12, "sadf", 5648] ---> ['sadf'], [12, 5648] """


list2 = [12, "sadf", 5648]
res_list1 = list(filter(lambda x: type(x) == int, list2))
res_list2 = list(filter(lambda x: type(x) != int, list2))

print(res_list1, res_list2)

