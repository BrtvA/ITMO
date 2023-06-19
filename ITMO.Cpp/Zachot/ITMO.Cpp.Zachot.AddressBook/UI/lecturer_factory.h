#pragma once
#include "../Entities/human.h"
#include "../Entities/lecturer.h"
#include "human_factory.h"
#include "../Entities/time.h"

class LecturerFactory : public HumanFactory {
 public:
	LecturerFactory(std::string, std::string, std::string, std::string, std::vector<Time>);
	Human* create() const override;
 protected:
	std::string phoneNumber;
	std::vector<Time> timeVector;
};
