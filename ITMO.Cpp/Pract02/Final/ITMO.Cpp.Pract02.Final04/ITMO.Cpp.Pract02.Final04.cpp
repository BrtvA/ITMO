#include <iostream>
#include <ctime>
#include <windows.h>

int getRandom(int min, int max) {
    return min + rand() % (max - min + 1);
}

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    std::srand(time(NULL));

    constexpr int kMinCenter = -10;
    constexpr int kMaxCenter = 10;
    constexpr int kScatter = 5;
    constexpr int kRadius10Point = 5;
    constexpr int kRadius5Point = 10;
    constexpr int kRadius1Point = 15;
    constexpr int kPoint10 = 10;
    constexpr int kPoint5 = 5;
    constexpr int kPoint1 = 1;
    constexpr int kMaxPoint = 50;
    constexpr int kCountSniper = 5;
    constexpr int kCountShooter = 7;

    int numberShots = 0;
    int posX, posY;
    int score = 0;
    std::string level;

    do {
        std::cout << "Введите координаты: ";
        std::cin >> posX;
        std::cin >> posY;

        int centerX = getRandom(kMinCenter, kMaxCenter);
        int centerY = getRandom(kMinCenter, kMaxCenter);

        int scatterX = getRandom(0, kScatter);
        int scatterY = getRandom(0, kScatter);

        double radius = std::sqrt((posX - scatterX - centerX)^2
                                + (posY - scatterY - centerY)^2);

        if (radius <= kRadius10Point) {
            score += kPoint10;
        }else if (radius <= kRadius5Point) {
            score += kPoint5;
        }
        else if (radius <= kRadius1Point) {
            score += kPoint1;
        }

        numberShots++;
    } while (score < kMaxPoint);

    if (numberShots <= kCountSniper) {
        level = "снайпер";
    }
    else if (numberShots <= kCountShooter) {
        level = "стрелок";
    }
    else {
        level = "новичок";
    }

    std::cout << "Количество выстрелов: " << numberShots
              << ". Уровень стрельбы: " << level << std::endl;
}
