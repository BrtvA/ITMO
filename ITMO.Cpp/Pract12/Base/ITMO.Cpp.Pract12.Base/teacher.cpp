#include "teacher.h"

Teacher::Teacher(std::string lastName, std::string name,
				 std::string secondName, unsigned int workTime) :
		Human(lastName, name, secondName) {
	this->workTime = workTime;
}

unsigned int Teacher::getWorkTime() {
	return this->workTime;
}