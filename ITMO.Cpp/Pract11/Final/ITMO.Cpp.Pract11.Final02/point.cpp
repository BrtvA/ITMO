#include <iostream>
#include "point.h"

Point::Point(double x, double y) : posX(x), posY(y) 
{}

Point::Point() : posX(0), posY(0)
{}

double Point::distanceTo() const {
	Point center;
	return std::sqrt(std::pow(Point::posX - center.posX, 2)
				   + std::pow(Point::posY - center.posY, 2));
}

bool Point::operator> (const Point& point) const {
	return Point::distanceTo() > point.distanceTo();
}

bool Point::operator< (const Point& point) const {
	return point.distanceTo() > Point::distanceTo();
}

std::ostream& operator<< (std::ostream& out, const Point& point) {
	out << "x = " << point.posX << ", y = " << point.posY << "\n";
	return out;
}