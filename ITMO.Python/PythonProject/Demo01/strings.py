string1 = "This is a string. "
string2 = " This is another string."
string3 = ".I see you."
str_qwerty = "qwerty"

first_num = 1 / 3
second_num = 2 / 3
third_num = 2 / 9

list1 = [82, 8, 23, 97, 92, 44, 17, 39, 11, 12]
list2 = [3, 5, 6, 2, 33, 6, 11]

seq = (2, 8, 23, 97, 92, 44, 17, 39, 11, 12)

dic = {'food': 'Apple', 'quantity': 4, 'color': 'Red'}
rec = {'name': {'firstname': 'Bob', 'lastname': 'Smith'},
       'job': ['dev', 'mgr'],
       'age': 25}


# Работа со строками
def print_strings(string1, string2, string3):
    print(string1 + string2)
    print(len(string1))
    print(string1.title())
    print(string2.lower())
    print(string1.upper())
    print(string1.rstrip())
    print(string2.lstrip())
    print((string2 + string1).strip())
    print(string3.strip('.'))


# Извлечение символов и подстрок
def print_substrings(str_qwerty):
    print(str_qwerty[2])
    print(str_qwerty[1:3])
    print(str_qwerty[1:])
    print(str_qwerty[:3])
    print(str_qwerty[:])
    print(str_qwerty[1:5:2])


# Преобразование данных
def print_data_convert():
    num1 = input("Enter the first number: ")
    num2 = input("Enter the second number: ")
    num3 = float(num1) + float(num2)
    print(num1 + " plus " + num2 + " = ", num3)


# Форматирование строк
def print_string_formatting(first_num, second_num, third_num):
    print("{:7.3f}".format(first_num))
    print("{:7.3f} {:7.3f}".format(second_num, third_num))
    print("{:10.3e} {:10.3e}".format(second_num, third_num))


# Списки
def print_list(list):
    print(dir(list))
    help(list.insert)
    help(list.append)
    help(list.sort)
    help(list.remove)
    help(list.reverse)

    print(list)
    list[0] = 88
    print(list)
    list.append(33)
    print(list)
    list.insert(0, 44)
    print(list)
    list.pop(0)
    print(list)
    list.pop()
    print(list)


# Сортировка элементов списка
def print_sort(list):
    sorted_list = sorted(list)
    print(list)
    print(sorted_list)


# Кортежи
def print_tuple(seq):
    help(seq.index)
    help(seq.count)
    print(seq.count(8))
    print(seq.index(44))
    list_seq = list(seq)
    print(type(list_seq))


# Словари
def print_dictionary(dic):
    print(dic['food'])
    dic['quantity'] += 10
    print(dic['quantity'])
    dic['name'] = input("Enter your name: ")
    dic['age'] = input("Enter your age: ")
    print(dic)


# Вложенность хранения данных
def print_attached_data(rec):
    print(f"{rec['name']['firstname']} {rec['name']['lastname']}")
    print(rec['name']['firstname'])
    print(rec['job'])
    rec['job'].append('janitor')
    print(rec['job'])
    print(f"{rec['name']['firstname']} {rec['name']['lastname']}\nAge: {rec['age']}\nJob: {rec['job']}")


print("  Работа со строками")
print_strings(string1, string2, string3)
print("\n  Извлечение символов и подстрок")
print_substrings(str_qwerty)
print("\n  Преобразование данных")
param = "string" + str(15)
print(param)
print_data_convert()
print("\n  Форматирование строк")
print_string_formatting(first_num, second_num, third_num)
print("\n  Списки")
print_list(list1)
print("\n  Сортировка элементов списка")
print_sort(list2)
print("\n  Словари")
print_dictionary(dic)
print("\n  Вложенность хранения данных")
print_attached_data(rec)
