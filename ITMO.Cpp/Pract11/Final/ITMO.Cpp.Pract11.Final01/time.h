#pragma once
#include <iostream>
#include<math.h>
#include<string>

class Time {
 public:
    class TimeError {
     public:
        TimeError(std::string);
        void printMessage() const;
     private:
        std::string message;
    };
    Time();
    Time(const int, const int, const int);
    Time operator+ (const Time&) const;
    friend Time operator+ (double, const Time&);
    friend Time operator+ (const Time&, double);
    Time operator- (const Time&) const;
    bool operator> (const Time&) const;
    bool operator< (const Time&) const;
    void showTime() const;
 private:
    int hours;
    int minutes;
    int seconds;
    std::string converter(const int&) const;
    int convertToSeconds() const;
};