#include "item.h"

void Item::getdata() {
	std::cout << "\n������� ��������� : ";
	std::cin >> title;
	std::cout << "������� ���� : ";
	std::cin >> price;
}

void Item::putdata() {
	std::cout << "\n���������: " << title;
	std::cout << "\n����: " << price;
}