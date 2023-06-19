#include <iostream>
#include <windows.h>

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    //Формат ввода СНИЛС: 1 2 3 4 5 6 7 8 9 00

    int num;
    int sum = 0;
    int inputCheckNum, checkNum;
    int remainder = 0;

    std::cout << "Введите СНИЛС: ";
    for (int pos = 9; pos >= 0; pos--) {
        std::cin >> num;

        if (pos != 0) {
            sum += num * pos;
        }
        else {
            inputCheckNum = num;
        }
    }

    remainder = sum % 101;

    if (sum < 100) {
        checkNum = inputCheckNum;
    }else if (sum == 100 || sum == 101) {
        checkNum = 0;
    }
    else if (remainder < 100) {
        checkNum = remainder;
    }
    else {
        checkNum = 0;
    }

    std::cout << "Результат проверки: ";
    if (checkNum == inputCheckNum) {
        std::cout << true << std::endl;
    }
    else {
        std::cout << false << std::endl;
    }
}
