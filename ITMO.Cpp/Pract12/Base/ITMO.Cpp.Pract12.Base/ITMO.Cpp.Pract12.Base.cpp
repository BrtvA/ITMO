#include <iostream>
#include <string>
#include <vector>
#include <windows.h>
#include "student.h"
#include "teacher.h"


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

    Student *stud = new Student("Петров", "Иван", "Алексеевич", scores);
    Teacher *tch = new Teacher("Сергеев", "Дмитрий", "Сергеевич", teacherWorkTime);

    std::cout << stud->getFullName() << std::endl;
    std::cout << "Средний балл : " << stud->getAverageScore() << std::endl;
    
    std::cout << tch->getFullName() << std::endl;
    std::cout << "Количество часов: " << tch->getWorkTime() << std::endl;

    delete tch;
    delete stud;

    return 0;
}