#pragma once
#include <iostream>
#include<string>

class SideError {
 public:
	SideError(const int);
	void printMessage() const;
 private:
	std::string message;
};