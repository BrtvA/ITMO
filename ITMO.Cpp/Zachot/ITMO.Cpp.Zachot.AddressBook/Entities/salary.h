#pragma once
#include <vector>
#include "time.h"

class Salary {
 public:
	Salary(std::vector<Time>);
	double calculate() const;
 private:
	const double COEFFICIENT = 200;
	std::vector<Time> timeArray;
};
