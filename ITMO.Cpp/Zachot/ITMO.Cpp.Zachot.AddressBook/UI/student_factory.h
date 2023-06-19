#pragma once
#include "../Entities/human.h"
#include "../Entities/student.h"
#include "human_factory.h"

class StudentFactory: public HumanFactory {
 public:
	StudentFactory(std::string, std::string, std::string, std::vector<int>);
	Human* create() const override;
 private:
	std::vector<int> scores;
};
