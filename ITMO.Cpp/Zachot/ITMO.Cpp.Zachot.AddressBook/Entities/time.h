#pragma once

class Time {
 public:
	Time(int, int);
	double convertToHours() const;
	Time operator- (const Time& secondTime) const;
 private:
	int hours;
	int minutes;
};
