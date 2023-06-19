#include "lecturer_factory.h"

LecturerFactory::LecturerFactory(std::string lastName, std::string name, 
								 std::string email, std::string phoneNumber, 
								 std::vector<Time> timeVector) : 
		HumanFactory(lastName, name, email) {
	LecturerFactory::phoneNumber = phoneNumber;
	LecturerFactory::timeVector = timeVector;
}

Human* LecturerFactory::create() const {
	return new Lecturer(LecturerFactory::lastName, 
						LecturerFactory::name, 
						LecturerFactory::email, 
						LecturerFactory::phoneNumber, 
						LecturerFactory::timeVector);
}