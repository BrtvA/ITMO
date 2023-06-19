#include <iostream>
#include "time.h"

Time::Time() : Time::Time(0, 0, 0)
{}

Time::Time(const int hrs, const int min, const int sec) {
	if (hrs < 0 || min < 0 || sec < 0) {
		throw Time::Time::TimeError("Время не может быть отрицательным");
	}

	Time::seconds = sec % 60;
	Time::minutes = (min + sec / 60) % 60;
	Time::hours = (hrs + (min + sec / 60) / 60) % 24;
}

void Time::showTime() const {
	std::cout << Time::converter(Time::hours) << ":"
			  << Time::converter(Time::minutes) << ":"
			  << Time::converter(Time::seconds) << std::endl;
}

std::string Time::converter (const int &value) const {
	return value < 10 ? ("0" + std::to_string(value)) : std::to_string(value);
}

Time Time::addTime(const Time &secondTime) const {
	int sumHours = Time::hours + secondTime.hours;
	int sumMinutes = Time::minutes + secondTime.minutes;
	int sumSeconds = Time::seconds + secondTime.seconds;

	if (sumHours > 24 || sumMinutes > 60 || sumSeconds > 60) {
		throw Time::Time::TimeError("Выход за пределы диапазонов значений");
	}

	Time time(sumHours, sumMinutes, sumSeconds);
	return time;
}

Time::TimeError::TimeError(std::string mes) : message(mes)
{}

void Time::TimeError::printMessage() const {
	std::cout << Time::TimeError::message << std::endl;
}
