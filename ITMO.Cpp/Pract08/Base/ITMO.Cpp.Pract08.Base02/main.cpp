#include <iostream>
#include <string>
#include "student.h"

using namespace std;

int main()
{
	// �������� ������� ������ Student
	Students student01;
	string name;
	string last_name;

	// ���� ����� � ����������
	cout << "Name: ";
	getline(cin, name);
	// ���� �������
	cout << "Last name: ";
	getline(cin, last_name);

	// ���������� ����� � ������� � ������ ������ Student
	student01.set_name(name);
	student01.set_last_name(last_name);

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
	student01.set_scores(scores);
	// ������� ������� ����
	double average_score = sum / 5.0;
	// ��������� ������� ���� � ������ ������ Student
	student01.set_average_score(average_score);

	// ������� ������ �� ��������
	cout << "Average ball for " << student01.get_name() << " "
		<< student01.get_last_name() << " is "
		<< student01.get_average_score() << endl;
	return 0;
}
