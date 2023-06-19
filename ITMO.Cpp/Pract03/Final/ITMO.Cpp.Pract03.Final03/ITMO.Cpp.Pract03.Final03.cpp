#include <iostream>
#include <cmath>
#include <windows.h>

double getTriangleSquare(double);
double getTriangleSquare(double, double, double);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    constexpr double fSide = 3;
    constexpr double fSide1 = 3;
    constexpr double fSide2 = 4;
    constexpr double fSide3 = 5;

    std::cout << "Площадь равностороннего треугольника со стороной "
              << fSide << " равна " << getTriangleSquare(fSide) << std::endl;
    std::cout << "Площадь разностороннего треугольника со сторонами "
              << fSide1 << ", " << fSide2 << ", " << fSide3 << " равна "
              << getTriangleSquare(fSide1, fSide2, fSide3) << std::endl;
}

double getTriangleSquare(double side) {
    return std::sqrt(3) * std::pow(side, 2) / 4;
}

double getTriangleSquare(double side1, double side2, double side3) {
    double p = (side1 + side2 + side3) / 2;
    return std::sqrt(p * (p - side1) * (p - side2) * (p - side3));
}