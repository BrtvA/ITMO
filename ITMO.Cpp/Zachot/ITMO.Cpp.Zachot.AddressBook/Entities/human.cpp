#include "human.h"

Human::Human(std::string lastName, std::string name, std::string email) : 
	lastName(lastName), name(name), email(email) 
{}

std::string Human::getFullName() const {
	return Human::lastName + " " + Human::name;
}

std::string Human::getContactInfo() const {
	return "email: " + Human::email;
}