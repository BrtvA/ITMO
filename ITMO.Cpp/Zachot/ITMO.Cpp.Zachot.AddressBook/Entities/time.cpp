#include "time.h"

Time::Time(int hrs, int min) : hours(hrs), minutes(min)
{}

double Time::convertToHours() const {
	return static_cast<double>(Time::hours)
		 + static_cast<double>(Time::minutes) / 60;
}

Time Time::operator- (const Time& secondTime) const {
	return Time(Time::hours - secondTime.hours, Time::minutes - secondTime.minutes);
}