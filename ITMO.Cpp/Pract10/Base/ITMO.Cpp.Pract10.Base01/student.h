#pragma once /* ������ �� �������� ����������� ������������� ����� */
#include <string>
#include "id_card.h"

using namespace std;

class Students {
 public:
	// ����������� ������ Student
	Students(string, string, IdCard*);
	// ������ ������ � �������� � ����
	void save();
	// ���������� ������ Student
	~Students();
	// ��������� ����� ��������
	void set_name(string);
	// ��������� ����� ��������
	string get_name();
	// ��������� ������� ��������
	void set_last_name(string);
	// ��������� ������� ��������
	string get_last_name();
	// ��������� ������������� ������
	void set_scores(int[]);
	// ��������� �������� �����
	void set_average_score(double);
	// ��������� �������� �����
	double get_average_score();

	void setIdCard(IdCard* c);
	IdCard getIdCard();
 private:
	// ������������� ������
	int scores[5];
	// ������� ����
	double average_score;
	// ���
	string name;
	// �������
	string last_name;

	IdCard* iCard;
};

