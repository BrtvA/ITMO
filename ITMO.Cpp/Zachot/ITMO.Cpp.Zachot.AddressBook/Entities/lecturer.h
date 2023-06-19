#pragma once
#include <string>
#include <vector>
#include "human.h"
#include "time.h"
#include "salary.h"

class Lecturer: public Human {
 public:
	Lecturer(std::string, std::string, std::string, std::string, std::vector<Time>);
	~Lecturer();
	std::string getContactInfo() const;
	std::string getAdditionalInfo() const override;
 private:
	std::string phoneNumber;
	Salary *salary;
};