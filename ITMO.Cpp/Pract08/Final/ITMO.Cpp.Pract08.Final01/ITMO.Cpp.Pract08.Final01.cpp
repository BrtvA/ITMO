#include <iostream>
#include <windows.h>
#include "time.h"

int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	const Time time1(2, 70, 65);
	const Time time2(25, 80, 35);
	Time time3;

	std::cout << "Первое время: ";
	time1.showTime();
	std::cout << "Второе время: ";
	time2.showTime();

	time3 = time2.addTime(time1);
	std::cout << "Сумма: ";
	time3.showTime();
}