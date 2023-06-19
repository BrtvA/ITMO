#include <iostream>
#include <string>
#include <windows.h>
#include "student.h"

using namespace std;

int main()
{
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);

	string name;
	string last_name;
	IdCard *idc = new IdCard(123, "�������");

	// ���� ����� � ����������
	cout << "Name: ";
	getline(cin, name);
	// ���� �������
	cout << "Last name: ";
	getline(cin, last_name);

	Students* student02 = new Students(name, last_name, idc);

	// ������
	int scores[5];
	// ����� ���� ������
	int sum = 0;
	// ���� ������������� ������
	for (int i = 0; i < 5; ++i) {
		cout << "Score " << i + 1 << ": ";
		cin >> scores[i];
		// ������������
		sum += scores[i];
	}

	// ��������� ������������� ������ � ������ ������ Student
	student02 -> set_scores(scores);
	// ������� ������� ����
	double average_score = sum / 5.0;
	// ��������� ������� ���� � ������ ������ Student
	student02 -> set_average_score(average_score);

	// ������� ������ �� ��������
	cout << "Average ball for " << student02 -> get_name() << " "
		<< student02 -> get_last_name() << " is "
		<< student02 -> get_average_score() << endl;
	cout << "IdCard: " << student02->getIdCard().getNumber() << endl;
	cout << "Category: " << student02->getIdCard().getCategory() << endl;

	delete student02;
	delete idc;

	return 0;
}
