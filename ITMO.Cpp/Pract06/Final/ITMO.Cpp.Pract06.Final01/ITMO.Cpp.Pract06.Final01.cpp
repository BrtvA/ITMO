#include <iostream>
#include <windows.h>
#include <fstream>

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    constexpr int fСharacterСount = 200;
    char str[fСharacterСount];

    std::cout << "Введите текст: " << std::endl;
    std::cin.get(str, fСharacterСount, '&');

    std::cout << "Вы ввели: \n" << str << std::endl;

    std::ofstream file("poem.txt");

    if (!file) {
        std::cout << "Запись в файл не выполнена" << std::endl;
        return 1;
    }

    file << str << std::endl;

    file.close();

    return 0;
}