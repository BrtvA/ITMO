#pragma once
#include "human.h"
#include <string>
#include <vector>

class Student : public Human {
 public:
	// ����������� ������ Student
	 Student(std::string, std::string,
			 std::string, std::vector<int>);
	// ��������� �������� ����� ��������
	float getAverageScore();
 private:
	// ������ ��������
	std::vector<int> scores;
};