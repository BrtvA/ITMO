#include <iostream>
#include <windows.h>
#include "triangle.h"
#include "side_error.h"

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    int sideA, sideB, sideC;

    std::cout << "Введите длину сторон треугольника: ";
    std::cin >> sideA;
    std::cin >> sideB;
    std::cin >> sideC;

    try {
        Triangle triangle(sideA, sideB, sideC);

        std::cout << "Площадь треугольника: "
            << triangle.getSquare() << std::endl;
    }
    catch (SideError &err) {
        std::cout << "ОШИБКА: ";
        err.printMessage();
    }
}