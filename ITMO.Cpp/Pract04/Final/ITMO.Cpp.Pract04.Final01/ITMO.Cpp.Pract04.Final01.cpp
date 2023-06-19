#include <iostream>
#include <windows.h>

int calculateQuadraticEquation(double, double, double,
                               double&, double&);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    double paramA, paramB, paramC;
    double root1, root2;
    int status;

    std::cout << "Введите коэффициенты квадратного уравнения вида "
              << "ax^2 + bx + c = 0" << std::endl;
    std::cout << "Коэффициент a: ";
    std::cin >> paramA;
    std::cout << "Коэффициент b: ";
    std::cin >> paramB;
    std::cout << "Коэффициент c: ";
    std::cin >> paramC;

    status = calculateQuadraticEquation(paramA, paramB, paramC,
                                        root1, root2);
    if (status == 1) {
        std::cout << "Корни уравнения "
                  << "x1 = " << root1
                  << ", x2 = " << root2 << std::endl;
    } else if (status == 0) {
        std::cout << "Корни уравнения x1 = x2 = "
                  << root1 << std::endl;
    } else {
        std::cout << "Корней уравнения нет" << std::endl;
    }
}

int calculateQuadraticEquation(double paramA, double paramB, double paramC,
                               double &root1, double &root2) {
    double discriminant = std::pow(paramB, 2) - 4 * paramA * paramC;
    
    if (discriminant < 0) {
        return -1;
    }

    root1 = (-paramB + std::sqrt(discriminant)) / (2 * paramA);

    if (discriminant > 0) {
        root2 = (-paramB - std::sqrt(discriminant)) / (2 * paramA);
        return 1;
    }
    else {
        return 0;
    }
}