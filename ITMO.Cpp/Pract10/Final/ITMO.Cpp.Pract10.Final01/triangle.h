#pragma once
#include <iostream>
#include "dot.h"

class Triangle {
public:
	Triangle(Dot*, Dot*, const int, const int);
	~Triangle();
	void showSide() const;
	int getPerimeter() const;
	double getSquare() const;
private:
	Dot *point1; 
	Dot *point2;
	Dot *point3;
};