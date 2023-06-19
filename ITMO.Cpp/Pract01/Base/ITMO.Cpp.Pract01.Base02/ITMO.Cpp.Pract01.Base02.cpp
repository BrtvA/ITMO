#include <iostream>
using namespace std;

int main(){
	system("chcp 1251");

	string name;
	double a, b;

	cout << "Введите свое имя\n";
	cout << "Введите a и b:\n";
	cin >> a; // ввод с клавиатуры значения a
	cin >> name;
	cin >> b; // ввод с клавиатуры значения b
	double x = a / b; // вычисление значения x

	cout.precision(3);
	cout << "\nx = " << x << endl; //вывод результата на экран
	cout << sizeof(a / b) << ends << sizeof(x) << endl;
	cout << "Привет, " << name << "!\n";
	
	return 0;
}
