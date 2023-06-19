#pragma once
#include "human.h"
#include <string>

class Teacher : public Human {
	// Конструктор класса teacher
 public:
	 Teacher(std::string, std::string,
			 std::string, unsigned int);
	// Получение количества учебных часов
	unsigned int getWorkTime();
 private:
	// Учебные часы
	unsigned int workTime;
};
