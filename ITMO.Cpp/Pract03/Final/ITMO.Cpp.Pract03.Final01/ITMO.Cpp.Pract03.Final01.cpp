#include <iostream>
#include <windows.h>

bool checkSnils();

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    std::cout << "Введите СНИЛС: ";
    std::cout << std::boolalpha
              << "Результат проверки: "
              << checkSnils() << std::endl;
}

bool checkSnils() {
    int sum = 0;
    int counter = 9;
    int inputCheckNum, checkNum;
    int remainder;

    while(true) {
        char symbol;
        std::cin >> symbol;
        if (symbol >= 48 && symbol <= 57) {
            sum += ((int)symbol - 48) * counter;
            counter--;
        }
        else if (symbol != '-') {
            return false;
        }

        if (counter == 0) {
            break;
        }
    }
    std::cin >> inputCheckNum;

    remainder = sum % 101;

    if (sum < 100) {
        checkNum = inputCheckNum;
    }
    else if (sum == 100 || sum == 101) {
        checkNum = 0;
    }
    else if (remainder < 100) {
        checkNum = remainder;
    }
    else {
        checkNum = 0;
    }

    return checkNum == inputCheckNum;
}