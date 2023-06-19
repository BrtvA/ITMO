#pragma once
#include <iostream>

class Point {
 public:
	 Point(double, double);
	 Point();
	 bool operator> (const Point&) const;
	 bool operator< (const Point&) const;
	 friend std::ostream& operator<< (std::ostream&, const Point&);
 private:
	 double posX;
	 double posY;
	 double distanceTo() const;
};