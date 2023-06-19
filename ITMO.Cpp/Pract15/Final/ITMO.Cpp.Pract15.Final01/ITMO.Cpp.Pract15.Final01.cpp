#include <iostream>
#include <string>
#include <map>
#include "student_grade.h"

int main() {
    const char grade5 = '5';
    const char grade4 = '4';
    const char grade3 = '3';
    const char grade2 = '2';

    const std::string nameIvan = "Ivan";
    const std::string namePetr = "Petr";
    const std::string nameAlex = "Alex";
    const std::string nameBob = "Bob";

    StudentGrade ivan(nameIvan, grade5);
    StudentGrade petr(namePetr, grade4);
    StudentGrade alex(nameAlex, grade3);
    StudentGrade bob(nameBob, grade2);

    std::map<std::string, char> studMap;
    studMap[ivan.name] = ivan.grade;
    studMap[petr.name] = petr.grade;
    studMap[alex.name] = alex.grade;
    studMap[bob.name] = bob.grade;

    for (auto item = studMap.begin(); item != studMap.end(); ++item)
    {
        std::cout<< item->first << ": " << item->second << std::endl;
    }
}