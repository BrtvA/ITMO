#include "student_factory.h"

StudentFactory::StudentFactory(std::string lastName, std::string name, std::string email, std::vector<int> scrs) :
		HumanFactory(lastName, name, email) {
	StudentFactory::scores = scrs;
}

Human* StudentFactory::create() const {
	return new Student(StudentFactory::lastName, 
					   StudentFactory::name, 
					   StudentFactory::email, 
					   StudentFactory::scores);
}