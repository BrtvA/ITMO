#include <iostream>
#include <windows.h>

bool isPrimeNumber(int number) {
    if (number < 2) {
        return false;
    }

    for (int num = 2; num <= number / 2; num++) {
        if (number % num == 0) {
            return false;
        }
    }

    return true;
}

int getPosition(int number) {
    int counter = 0;

    for (int num = 2; num <= number; num++) {
        if (isPrimeNumber(num)) {
            counter++;
        }
    }

    return counter;
}

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    int num;

    std::cout << "Введите число: \n";
    std::cin >> num;

    if (!isPrimeNumber(num)) {
        std::cout << "Число не является простым";
    }
    else if (isPrimeNumber(getPosition(num))){
        std::cout << "Число является суперпростым";
    }
    else {
        std::cout << "Число не является суперпростым";
    }
}