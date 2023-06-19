#pragma once
#include <string>
#include <sstream>

class Human {
 public:
	// Конструктор класса human
	Human(std::string, std::string, std::string);
	// Получение ФИО человека
	std::string getFullName();
 private:
	std::string name; // имя
	std::string lastName; // фамилия
	std::string secondName; // отчество
};

