#include <iostream>
#include<math.h>
#include "time.h"

Time::Time() : Time::Time(0, 0, 0)
{}

Time::Time(const int hrs, const int min, const int sec) : 
	hours(hrs), minutes(min), seconds(sec) 
{}

void Time::showTime() const {
	std::cout << Time::converter(Time::hours) << ":"
			  << Time::converter(Time::minutes) << ":"
			  << Time::converter(Time::seconds) << std::ends;
}

std::string Time::converter (const int &value) const {
	return value < 10 ? ("0" + std::to_string(value)) : std::to_string(value);
}

int Time::convertToSeconds() const {
	return Time::hours * 3600 + Time::minutes * 60 + Time::seconds;
}

Time::TimeError::TimeError(std::string mes) : message(mes)
{}

void Time::TimeError::printMessage() const {
	std::cout << Time::TimeError::message << std::endl;
}

Time Time::operator+ (const Time &secondTime) const {
	int sumHours = Time::hours + secondTime.hours;
	int sumMinutes = Time::minutes + secondTime.minutes;
	int sumSeconds = Time::seconds + secondTime.seconds;

	int normSeconds = sumSeconds % 60;
	int normMinutes = (sumMinutes + sumSeconds / 60) % 60;
	int normHours = (sumHours + (sumMinutes + sumSeconds / 60) / 60) % 24;

	Time time(normHours, normMinutes, normSeconds);

	if (time.convertToSeconds() > 24 * 3600) {
		throw Time::Time::TimeError("¬ыход за пределы диапазонов значений");
	}

	return time;
}

Time Time::operator- (const Time &secondTime) const {
	if (secondTime > *this) {
		throw Time::Time::TimeError("¬ыход за пределы диапазонов значений");
	}

	int sec = 0;
	int min = 0;
	int hrs = 0;

	sec = Time::seconds - secondTime.seconds;
	if (sec < 0) {
		min--;
		sec = 60 + sec;
	}

	min += Time::minutes - secondTime.minutes;
	if (min < 0) {
		hrs += min / 60 - (min % 60 < 0);
		min = 60 + min % 60;
	}

	hrs += Time::hours - secondTime.hours;
	if (hrs < 0) {
		hrs = 24 + hrs % 24;
	}

	Time time(hrs, min, sec);
	return time;
}

bool Time::operator> (const Time &secondTime) const {
	return Time::convertToSeconds() > secondTime.convertToSeconds();
}

bool Time::operator< (const Time &secondTime) const {
	return secondTime > *this;
}

Time operator+ (double hours, const Time& secondTime) {
	double hrs, min;
	double sec = std::modf(std::modf(hours, &hrs) * 60, &min) * 60;

	Time firstTime(static_cast<int>(hrs),
				   static_cast<int>(min), 
				   static_cast<int>(sec));
	return (firstTime + secondTime);
}

Time operator+ (const Time& firstTime, double hours) {
	return hours + firstTime;
}
