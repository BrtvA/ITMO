#pragma once
#include "human.h"
#include <string>
#include <vector>

class Student : public Human {
 public:
	// Конструктор класса Student
	 Student(std::string, std::string,
			 std::string, std::vector<int>);
	// Получение среднего балла студента
	float getAverageScore();
 private:
	// Оценки студента
	std::vector<int> scores;
};