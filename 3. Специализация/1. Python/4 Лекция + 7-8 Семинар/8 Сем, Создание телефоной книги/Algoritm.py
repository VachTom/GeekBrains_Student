from Functional import create
from Interface import interface
path = "phone_book.txt"
create(path)
enter = 0
while enter != 4:
    enter = interface()
    if enter == 1:
        from Functional import add_cont
        stroka = str(input("Введите ФИО и номер телефона через пробел "))
        add_cont(path, stroka)
    if enter == 2:
        from Functional import show_all
        print(show_all(path))
    if enter == 3:
        from Functional import search
        stroka = str(input("Введите фамилию: "))
        search(path, stroka)
print("Спасибо за работу")