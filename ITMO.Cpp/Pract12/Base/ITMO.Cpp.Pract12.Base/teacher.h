#pragma once
#include "human.h"
#include <string>

class Teacher : public Human {
	// ����������� ������ teacher
 public:
	 Teacher(std::string, std::string,
			 std::string, unsigned int);
	// ��������� ���������� ������� �����
	unsigned int getWorkTime();
 private:
	// ������� ����
	unsigned int workTime;
};
