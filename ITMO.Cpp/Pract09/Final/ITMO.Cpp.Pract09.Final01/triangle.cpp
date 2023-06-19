#include "triangle.h"
#include "side_error.h"

Triangle::Triangle(const int side1, const int side2, const int side3):
	sideA(side1), sideB(side2), sideC(side3)
{
	checkSide(sideA, sideB, sideC);
	checkSide(sideB, sideA, sideC);
	checkSide(sideC, sideB, sideA);
}

double Triangle::getSquare() const {
	double p = static_cast<double>(Triangle::sideA + Triangle::sideB + Triangle::sideC) / 2;
	return std::sqrt(p * (p - Triangle::sideA)
					   * (p - Triangle::sideB)
					   * (p - Triangle::sideC));
}

void Triangle::checkSide(int &sideA, int &sideB, int &sideC) {
	if (sideA > (sideB + sideC)) {
		throw SideError(sideA);
	}
}