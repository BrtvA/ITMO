#include <iostream>
#include <windows.h>

struct Root {
    double root1;
    double root2;
};

Root calculateQuadraticEquation(const double, const double, const double, int&);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    double paramA, paramB, paramC;
    Root root;
    int status;

    std::cout << "Введите коэффициенты квадратного уравнения вида "
              << "ax^2 + bx + c = 0" << std::endl;
    std::cout << "Коэффициент a: ";
    std::cin >> paramA;
    std::cout << "Коэффициент b: ";
    std::cin >> paramB;
    std::cout << "Коэффициент c: ";
    std::cin >> paramC;

    root = calculateQuadraticEquation(paramA, paramB, paramC, status);
    if (status == 1) {
        std::cout << "Корни уравнения "
            << "x1 = " << root.root1
            << ", x2 = " << root.root2 << std::endl;
    }
    else if (status == 0) {
        std::cout << "Корни уравнения x1 = x2 = "
            << root.root1 << std::endl;
    }
    else {
        std::cout << "Корней уравнения нет" << std::endl;
    }
}

Root calculateQuadraticEquation(const double paramA, const double paramB,
                                const double paramC, int& status) {
    Root root;

    double discriminant = std::pow(paramB, 2) - 4 * paramA * paramC;

    if (discriminant < 0) {
        status = -1;
    } else {
        root.root1 = (-paramB + std::sqrt(discriminant)) / (2 * paramA);

        if (discriminant > 0) {
            root.root2 = (-paramB - std::sqrt(discriminant)) / (2 * paramA);
            status = 1;
        }
        else {
            status = 0;
        }
    }

    return root;
}