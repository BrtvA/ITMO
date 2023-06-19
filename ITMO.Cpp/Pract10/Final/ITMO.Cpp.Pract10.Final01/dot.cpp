#include <iostream>
#include <math.h>
#include "dot.h"

Dot::Dot() {
	x = 0; y = 0;
}

Dot::Dot(double x, double y) {
	this->x = x;
	this->y = y;
}

double Dot::distanceTo(Dot point) {
	return std::sqrt(std::pow((point.x - Dot::x), 2)
				   + std::pow((point.y - Dot::y), 2));
}
