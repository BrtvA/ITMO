#pragma once
#include <string>
#include <sstream>

class Human {
 public:
	// ����������� ������ human
	Human(std::string, std::string, std::string);
	// ��������� ��� ��������
	std::string getFullName();
 private:
	std::string name; // ���
	std::string lastName; // �������
	std::string secondName; // ��������
};

