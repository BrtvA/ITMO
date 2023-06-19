#include "salary.h"

Salary::Salary(std::vector<Time> tArr) : timeArray(tArr) 
{}

double Salary::calculate() const {
	double hrs = 0;
	for (int i = 0; i < Salary::timeArray.size(); i+=2) {
		hrs += (Salary::timeArray[i + 1] - Salary::timeArray[i]).convertToHours();
	}
	return Salary::COEFFICIENT * hrs;
}