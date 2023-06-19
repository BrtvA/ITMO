#pragma once
#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include "../Entities/student.h"
#include "../Entities/lecturer.h"
#include "../Entities/human.h"
#include "human_factory.h"
#include "student_factory.h"
#include "lecturer_factory.h"

class UIManager {
public:
	UIManager(std::vector<Human*>&);
	~UIManager();
	void inputData();
	void printData();
private:
	const char STOP_CHAR = '/';
	const char TIME_DELIMITER = ':';
	const std::string FILE_NAME = "persons.txt";
	const std::string INVALID_INPUT_EXCEPTION = "Invalid input format.";
	std::vector<Human*> &persons;
	std::vector<std::string> split(std::string, const char);
	HumanFactory* humanFactory;
	bool saveData();
};
