#include <iostream>
#include <string>
#include <vector>
#include <algorithm> // для алгоритма сортировки
#include <windows.h>
#include "point.h"

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    std::vector<Point> v;
    v.push_back(Point(1, 2));
    v.push_back(Point(10, 12));
    v.push_back(Point(21, 7));
    v.push_back(Point(4, 8));
    std::sort(v.begin(), v.end()); // требуется перегрузка оператора < для
                                   // класса Point
    for (auto &point : v)
        std::cout << point << '\n'; // требуется перегрузка оператора << для 
                                    // класса Point
    return 0;
}