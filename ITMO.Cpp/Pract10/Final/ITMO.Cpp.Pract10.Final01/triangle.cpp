#include <iostream>
#include "triangle.h"

Triangle::Triangle(Dot *dot1, Dot *dot2,
				   const int posX, const int posY) : point1(dot1), point2(dot2) {
	Triangle::point3 = new Dot(posX, posY); //point1 � point2 - ���������, point3 - ����������
}

Triangle::~Triangle() {
	delete Triangle::point3;
}

void Triangle::showSide() const {
	std::cout << "����� ������ �������������: "
			  << Triangle::point1->distanceTo(*Triangle::point2) << ", "
			  << Triangle::point2->distanceTo(*Triangle::point3) << ", "
			  << Triangle::point3->distanceTo(*Triangle::point1) << std::endl;
}

int Triangle::getPerimeter() const {
	return Triangle::point1->distanceTo(*Triangle::point2) 
		 + Triangle::point2->distanceTo(*Triangle::point3)
		 + Triangle::point3->distanceTo(*Triangle::point1);
}

double Triangle::getSquare() const{
	double semiPerimeter = static_cast<double>(Triangle::getPerimeter()) / 2;
	return std::sqrt(semiPerimeter * (semiPerimeter - Triangle::point1->distanceTo(*Triangle::point2))
								   * (semiPerimeter - Triangle::point2->distanceTo(*Triangle::point3))
								   * (semiPerimeter - Triangle::point3->distanceTo(*Triangle::point1)));
}