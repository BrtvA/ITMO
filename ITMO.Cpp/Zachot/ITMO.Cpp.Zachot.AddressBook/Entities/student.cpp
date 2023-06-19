#include "student.h"
#include "scores.h"

Student::Student(std::string lastName, std::string name,
				 std::string email, std::vector<int> scrs):
		Human(lastName, name, email){
	Student::scores = new Scores(scrs);
}

Student::~Student() {
	delete Student::scores;
}

std::string Student::getAdditionalInfo() const {
	return "average score: " + std::to_string(Student::scores->getAverageValue());
}