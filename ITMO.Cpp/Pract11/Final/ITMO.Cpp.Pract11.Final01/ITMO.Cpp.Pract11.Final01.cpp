#include <iostream>
#include <windows.h>
#include "time.h"

int main() {
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	const Time time1(3, 30, 35);
	const Time time2(2, 20, 15);
	double hours = 1.5;
	Time time3, time4, time5, time6;

	try {
		std::cout << "Первое время: ";
		time1.showTime();
		std::cout << std::endl;
		std::cout << "Второе время: ";
		time2.showTime();
		std::cout << std::endl;

		time3 = time1 + time2;
		time1.showTime();
		std::cout << " + ";
		time2.showTime();
		std::cout << " = ";
		time3.showTime();
		std::cout << std::endl;

		time4 = time1 - time2;
		time1.showTime();
		std::cout << " - ";
		time2.showTime();
		std::cout << " = ";
		time4.showTime();
		std::cout << std::endl;

		time5 = time1 + 1.5;
		time1.showTime();
		std::cout << " + ";
		std::cout << hours;
		std::cout << " = ";
		time5.showTime();
		std::cout << std::endl;

		time6 = hours + time1;
		std::cout << hours;
		std::cout << " + ";
		time1.showTime();
		std::cout << " = ";
		time6.showTime();
		std::cout << std::endl;
	}
	catch (Time::TimeError& err) {
		std::cout << "Ошибка: ";
		err.printMessage();
	}

	time1.showTime();
	std::cout << " < ";
	time2.showTime();
	std::cout << " = " << std::boolalpha
			  << (time1 < time2)
			  << std::endl;

	time1.showTime();
	std::cout << " > ";
	time2.showTime();
	std::cout << " = " << std::boolalpha
			  << (time1 > time2)
			  << std::endl;
}