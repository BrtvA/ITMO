#include <iostream>
#include <windows.h>
#include "dot.h"
#include "triangle.h"

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    Dot *point1 = new Dot();
    Dot *point2 = new Dot(0, 3);
    Triangle triangle(point1, point2, 4, 0);

    triangle.showSide();
    std::cout << "Периметр треугольника: " << triangle.getPerimeter() << std::endl;
    std::cout << "Площадь треугольника: " << triangle.getSquare() << std::endl;

    delete point1;
    delete point2;
}
