#include "side_error.h"

SideError::SideError(const int side){
	SideError::message = "—торона c длиной " + std::to_string(side) + " имеет недопустимую длину";
}

void SideError::printMessage() const { 
	std::cout << SideError::message << std::endl;
}