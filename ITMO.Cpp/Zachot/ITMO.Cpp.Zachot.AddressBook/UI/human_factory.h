#pragma once
#include "../Entities/human.h"

class HumanFactory {
 public:
	 HumanFactory(std::string, std::string, std::string);
	 virtual Human* create() const = 0;
 protected:
	 std::string lastName;
	 std::string name;
	 std::string email;
};
