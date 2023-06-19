#include "human.h"

Human::Human(std::string lastName, std::string name,
			 std::string secondName) {
	this->lastName = lastName;
	this->name = name;
	this->secondName = secondName;
}

std::string Human::getFullName() {
	std::ostringstream fullName;
	fullName << this->lastName << " "
		<< this->name << " "
		<< this->secondName;
	return fullName.str();
}

float Human::getInfo() {
	return 0;
}