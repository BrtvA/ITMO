#pragma once
#include <vector>

class Scores {
 public:
	Scores(std::vector<int>);
	double getAverageValue();
 private:
	 std::vector<int> values;
};