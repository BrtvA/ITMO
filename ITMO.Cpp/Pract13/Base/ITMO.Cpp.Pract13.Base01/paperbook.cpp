#include "paperbook.h"

void Paperbook::getdata() {
	Item::getdata();
	std::cout << "������� ����� �������: ";
	std::cin >> pages;
}

void Paperbook::putdata() {
	Item::putdata();
	std::cout << "\n�������: " << pages;
}