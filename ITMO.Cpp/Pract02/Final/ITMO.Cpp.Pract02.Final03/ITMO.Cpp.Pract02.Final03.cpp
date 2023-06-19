#include <iostream>
#include <windows.h>

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    constexpr double fCoins[7] = { 0.05, 0.1, 0.5, 1, 2, 5, 10 };
    double sum;
    double value;
    int coinCount;

    std::cout << "Введите сумму в рублях: ";
    std::cin >> sum;

    while (sum > 0) {
        value = 0;
        for (auto item : fCoins) {
            if (item > value && item <= sum) {
                value = item;
            }
        }

        coinCount = sum / value;
        std::cout << "Монеты по " << value
                  << " руб - " << coinCount << " шт." << std::endl;
        sum -= coinCount * value;
    }
}