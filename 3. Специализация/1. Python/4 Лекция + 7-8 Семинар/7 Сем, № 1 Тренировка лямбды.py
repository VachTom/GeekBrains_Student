# Ляьбда
# def n(x):
#     return x + 1
# plus = lambda x: x + 1


# Map
list1 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
list2 = list(map(lambda x: x + 1, list1))
print(list2)


list3 = list(map(int, input().split())) # Ввод чисел через пробел
print(list3)


# Filter
res_list = list(filter(lambda x: x % 2 == 0, list1))


# Zip
zip1 = zip([1,2]  [a,b], [f,s,t])



# enumerate 
enumerate(["ноль","один","два","три",])
[(0,"ноль"),(1,"один"),(2,"два"),(3,"три "),]