#include <iostream>
#include "time.h"

Time::Time() : Time::Time(0, 0, 0)
{}

Time::Time(const int hrs, const int min, const int sec) {
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
	Time time(Time::hours + secondTime.hours,
			  Time::minutes + secondTime.minutes,
			  Time::seconds + secondTime.seconds);
	return time;
}