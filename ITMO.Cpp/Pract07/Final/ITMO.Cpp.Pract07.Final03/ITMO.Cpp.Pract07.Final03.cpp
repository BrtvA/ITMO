#include <iostream>
#include <windows.h>
#include <tuple>

using Tuple = std::tuple<double, double, int>;

Tuple calculateQuadraticEquation(const double, const double, const double);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    double paramA, paramB, paramC;

    std::cout << "Введите коэффициенты квадратного уравнения вида "
        << "ax^2 + bx + c = 0" << std::endl;
    std::cout << "Коэффициент a: ";
    std::cin >> paramA;
    std::cout << "Коэффициент b: ";
    std::cin >> paramB;
    std::cout << "Коэффициент c: ";
    std::cin >> paramC;

    Tuple root = calculateQuadraticEquation(paramA, paramB, paramC);
    if (std::get<2>(root) == 2) {
        std::cout << "Корни уравнения "
            << "x1 = " << std::get<0>(root)
            << ", x2 = " << std::get<1>(root) << std::endl;
    }
    else if (std::get<0>(root) == 1) {
        std::cout << "Корни уравнения x1 = x2 = "
            << std::get<1>(root) << std::endl;
    }
    else {
        std::cout << "Корней уравнения нет" << std::endl;
    }
}

Tuple calculateQuadraticEquation(const double paramA, const double paramB,
                                 const double paramC) {
    double root1;
    double root2;
    int status;

    double discriminant = std::pow(paramB, 2) - 4 * paramA * paramC;

    if (discriminant < 0) {
        status = 0;
    }
    else {
        root1 = (-paramB + std::sqrt(discriminant)) / (2 * paramA);

        if (discriminant > 0) {
            root2 = (-paramB - std::sqrt(discriminant)) / (2 * paramA);
            status = 2;
        }
        else {
            root2 = root1;
            status = 1;
        }
    }

    return std::make_tuple(root1, root2, status);
}