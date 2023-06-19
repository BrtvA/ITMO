#include "student.h"

Student::Student(std::string lastName, std::string name,
				 std::string secondName, std::vector<int> scores) :
		Human(lastName, name, secondName) {
	this->scores = scores;
}

float Student::getAverageScore() {
	// Общее количество оценок
	unsigned int countScores = this->scores.size();
	// Сумма всех оценок студента
	unsigned int sum_scores = 0;
	// Средний балл
	float average_score;
	for (unsigned int i = 0; i < countScores; ++i) {
		sum_scores += this->scores[i];
	}
	average_score = (float)sum_scores / (float)countScores;
	return average_score;
}