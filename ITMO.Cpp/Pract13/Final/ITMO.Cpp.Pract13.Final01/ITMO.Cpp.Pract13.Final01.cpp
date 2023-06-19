#include <iostream>
#include <string>
#include <vector>
#include <windows.h>
#include "student.h"
#include "teacher.h"
#include "human.h"


int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    std::vector<int> scores;
    unsigned int teacherWorkTime = 40;

    scores.push_back(5);
    scores.push_back(3);
    scores.push_back(4);
    scores.push_back(4);
    scores.push_back(5);
    scores.push_back(3);
    scores.push_back(3);
    scores.push_back(3);
    scores.push_back(3);

    Human *human = new Student("Петров", "Иван", "Алексеевич", scores);
    std::cout << human->getFullName() << std::endl;
    std::cout << "Количество часов: " << human->getInfo() << std::endl;
    
    human = new Teacher("Сергеев", "Дмитрий", "Сергеевич", teacherWorkTime);
    std::cout << human->getFullName() << std::endl;
    std::cout << "Средний балл : " << human->getInfo() << std::endl;

    delete human;

    return 0;
}