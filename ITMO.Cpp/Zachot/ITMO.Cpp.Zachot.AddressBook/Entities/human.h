#pragma once
#include <string>

class Human {
 public:
	Human(std::string, std::string, std::string);
	std::string getFullName() const;
	virtual std::string getContactInfo() const;
	virtual std::string getAdditionalInfo() const = 0;
	std::string toString() const {
		return getFullName() + "\t"
			 + getContactInfo() + "\t"
			 + getAdditionalInfo();
	}

 private:
	std::string name;
	std::string lastName;
	std::string email;
};
