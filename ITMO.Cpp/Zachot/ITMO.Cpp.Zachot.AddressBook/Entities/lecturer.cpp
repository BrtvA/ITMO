#include "lecturer.h"

Lecturer::Lecturer(std::string lastName, std::string name,
				   std::string email, std::string phoneNumber,
				   std::vector<Time> tArr):
		Human(lastName, name, email) {
	Lecturer::salary = new Salary(tArr);
	Lecturer::phoneNumber = phoneNumber;
}

Lecturer::~Lecturer() {
	delete Lecturer::salary;
}

std::string Lecturer::getContactInfo() const {
	return Lecturer::Human::getContactInfo() + "\t"
		+ "phone number: " + Lecturer::phoneNumber;
}

std::string Lecturer::getAdditionalInfo() const {
	return "salary: " + std::to_string(Lecturer::salary->calculate());
}