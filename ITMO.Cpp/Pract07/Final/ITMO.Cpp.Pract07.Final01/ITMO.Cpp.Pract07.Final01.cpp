#include <iostream>
#include <windows.h>

using std::cin;
using std::cout;
using std::endl;

struct Time {
    int hours;
    int minutes;
    int seconds;

    Time addTime(const Time &time) {
        int sumSec = seconds + time.seconds;
        int sumMin = minutes + time.minutes;

        int sec = sumSec % 60;
        int min = (sumMin + (sumSec / 60)) % 60;
        int hrs = (hours + time.hours + (sumMin + (sumSec / 60)) / 60) % 60;

        return { hrs, min, sec };
    }

    Time subTime(const Time &time) {
        int sec = 0;
        int min = 0;
        int hrs = 0;

        sec = seconds - time.seconds;
        if (sec < 0) {
            min--;
            sec = 60 + sec;
        }

        min += minutes - time.minutes;
        if (min < 0) {
            hrs += min / 60 - (min % 60 < 0);
            min = 60 + min % 60;
        }

        hrs += hours - time.hours;
        if (hrs < 0) {
            hrs = 24 + hrs % 24;
        }

        return { hrs, min, sec };
    }
};

void showSeconds(const Time&);
void showTime(const Time&);
int inputTime(Time&);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    
    Time currentTime;
    Time newTime;

    if (inputTime(currentTime) != 1 || inputTime(newTime) != 1) {
        cout << "Неверный формат времени " << endl;
        return 1;
    }

    cout << "Количество секунд в первой структуре времени: ";
    showSeconds(currentTime);
    cout << "Количество секунд во второй структуре времени: ";
    showSeconds(newTime);

    cout << "Время после сложения структур времени: ";
    showTime(currentTime.addTime(newTime));
    cout << "Время после вычитания структур времени: ";
    showTime(currentTime.subTime(newTime));
}

void showSeconds(const Time &time) {
    cout << time.hours * 3600 + time.minutes * 60 + time.seconds << endl;
}

void showTime(const Time& time) {
    cout << time.hours << " часов, " 
         << time.minutes << " минут, "
         << time.seconds << " секунд" << endl;
}

int inputTime(Time &time) {
    cout << "Введите количество часов: ";
    cin >> time.hours;
    cout << "Введите количество минут: ";
    cin >> time.minutes;
    cout << "Введите количество секунд: ";
    cin >> time.seconds;
    cout << endl;

    if (time.hours >= 0 && time.hours <= 24
        && time.minutes >= 0 && time.minutes <= 60
        && time.seconds >= 0 && time.seconds <= 60) {
        return 1;
    } else {
        return 0;
    }
}