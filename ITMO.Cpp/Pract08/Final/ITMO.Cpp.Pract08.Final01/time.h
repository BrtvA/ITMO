#pragma once
#include <iostream>
#include<string>

class Time {
 public:
    Time();
    Time(const int, const int, const int);
    Time addTime(const Time&) const;
    void showTime() const;
 private:
    int hours;
    int minutes;
    int seconds;
    std::string converter(const int&) const;
};