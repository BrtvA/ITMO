#pragma once
#include "human.h"
#include <string>

class Teacher : public Human {
	// Конструктор класса teacher
 public:
	 Teacher(std::string, std::string,
			 std::string, unsigned int);
	 float getInfo();
 private:
	// Учебные часы
	unsigned int workTime;
	// Получение количества учебных часов
	unsigned int getWorkTime();
};
