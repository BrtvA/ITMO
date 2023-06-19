#pragma once
#include <string>
#include <sstream>

class Human {
 public:
	// Конструктор класса human
	Human(std::string, std::string, std::string);
	// Получение ФИО человека
	virtual std::string getFullName();
	virtual float getInfo();

 private:
	std::string name; // имя
	std::string lastName; // фамилия
	std::string secondName; // отчество
};

