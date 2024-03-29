﻿#include <iostream>
#include<cmath>
#include <windows.h>

int main(){
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    std::cout << "Введите координаты пятиугольника:\n";

    double x1, x2, x3, x4, x5;
    double y1, y2, y3, y4, y5;
    double leftSum, rightSum;
    double square;

    std::cin >> x1;
    std::cin >> y1;
    std::cin >> x2;
    std::cin >> y2;
    std::cin >> x3;
    std::cin >> y3;
    std::cin >> x4;
    std::cin >> y4;
    std::cin >> x5;
    std::cin >> y5;

    leftSum = x1 * y2 + x2 * y3 + x3 * y4 + x4 * y5;
    rightSum = x5 * y4 + x4 * y3 + x3 * y2 + x2 * y1;
    square = 0.5 * std::abs(leftSum - rightSum);

    std::cout << "Площадь по формуле Гаусса: " << square << std::endl;
}
