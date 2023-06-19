#include <iostream>
#include <windows.h>

int sumSeries(int);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    int count;

    std::cout << "Введите количество слагаемых ряда: ";
    std::cin >> count;
    std::cout << "Сумма ряда: " << sumSeries(count) << std::endl;
}

int sumSeries(int count) {
    if (count == 0) {
        return 0;
    }
    else {
        return 5 * count + sumSeries(count - 1);
    }
}