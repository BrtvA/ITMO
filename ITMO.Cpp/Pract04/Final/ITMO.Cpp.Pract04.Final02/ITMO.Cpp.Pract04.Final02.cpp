#include <iostream>
#include <windows.h>
using std::cerr;
using std::cout;
using std::cin;

bool input(int&, int&);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    int a, b;
    if (!input(a, b))
    {
        cerr << "error";
        return 1;
    }
    int s = a + b;
    return 0;
}

bool input(int &value1, int &value2) {
    cout << "Введите два числа: ";
    cin >> value1;
    cin >> value2;

    if (value1 > value2) {
        return true;
    } else {
        return false;
    }
}
