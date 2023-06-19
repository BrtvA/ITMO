#include "scores.h"

Scores::Scores(std::vector<int> val) : values(val)
{}

double Scores::getAverageValue() {
	unsigned int countScores = this->values.size();
	unsigned int sumScores = 0;
	for (unsigned int i = 0; i < countScores; ++i) {
		sumScores += this->values[i];
	}
	return static_cast<double>(sumScores) / countScores;
}