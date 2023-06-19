#include <iostream>
#include <string> 
#include <windows.h>

std::string convertToBinary(int);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    int num;
    std::cout << "Введите десятичное число: ";
    std::cin >> num;
    std::cout << "Двоичная форма числа: " << convertToBinary(num) << std::endl;
}

std::string convertToBinary(int num) {
    if (num < 2) {
        return std::to_string(num);
    }
    else {
        return convertToBinary(num / 2) + std::to_string(num % 2);
    }
}