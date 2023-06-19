#include <iostream>
#include <windows.h>
#include "time.h"

int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	try {
		const Time time1(22, 50, 15);
		const Time time2(23, 40, 35);
		Time time3;

		std::cout << "Первое время: ";
		time1.showTime();
		std::cout << "Второе время: ";
		time2.showTime();

		time3 = time2.addTime(time1);
		std::cout << "Сумма: ";
		time3.showTime();
	}
	catch (Time::TimeError& err) {
		std::cout << "Ошибка: ";
		err.printMessage();
	}
}