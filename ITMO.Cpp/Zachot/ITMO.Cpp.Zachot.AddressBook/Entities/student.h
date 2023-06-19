#pragma once
#include <vector>
#include "human.h"
#include "scores.h"

class Student : public Human {
 public:
	Student(std::string, std::string, std::string, std::vector<int>);
	~Student();
	std::string getAdditionalInfo() const override;
 private:
	Scores *scores;
};
