#include <iostream>
#include<cmath>
#include <windows.h>

double getCubeRoot(double);
double getCubeRoot(double, double);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    constexpr double fGap = 1e-10;
    double value;

    std::cout << "Кубический корень из ";
    std::cin >> value;
    std::cout << "Стандартная функция:  "
              << getCubeRoot(value) << std::endl;
    std::cout << "Итерационная формула:  "
              << getCubeRoot(value, fGap) << std::endl;
}

double getCubeRoot(double value) {
    return std::pow(value, 1.0 / 3);
}

double getCubeRoot(double value, double gap) {
    double res1;
    double res2 = value;

    do{
        res1 = res2;
        res2 = (value / (res1 * res1) + 2 * res1) / 3;
    } while ((res1 - res2) > gap);

    return res2;
}