#pragma once
#include <iostream>

class Triangle {
 public:
	Triangle (const int, const int, const int);
	double getSquare() const;
 private:
	int sideA, sideB, sideC;
	void checkSide(int&, int&, int&);
};