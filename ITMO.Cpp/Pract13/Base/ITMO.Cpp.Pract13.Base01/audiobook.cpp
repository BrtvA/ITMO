#include "audiobook.h"

void Audiobook::getdata() {
	Item::getdata();
	std::cout << "������� ����� ��������: ";
	std::cin >> time;
}

void Audiobook::putdata() {
	Item::putdata();
	std::cout << "\n����� �������� : " << time;
}