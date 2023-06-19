#include "side_error.h"

SideError::SideError(const int side){
	SideError::message = "������� c ������ " + std::to_string(side) + " ����� ������������ �����";
}

void SideError::printMessage() const { 
	std::cout << SideError::message << std::endl;
}