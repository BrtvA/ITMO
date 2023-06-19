#include <iostream>
#include <vector>
#include <string>
#include "Entities/student.h"
#include "Entities/lecturer.h"
#include "Entities/human.h"
#include "UI/ui_manager.h"

int main() {
    std::string answer;
    std::vector<Human*> persons;
    UIManager uiManager(persons);
    while (true) {
        try {
            uiManager.inputData();

            std::cout << "\nAdd another person? (yes/no) [y/n] => ";
            std::cin >> answer;
            std::cout << std::endl;
            if (answer == "n") {
                break;
            }
        } 
        catch (std::string ex) {
            std::cout << "\nError: " + ex + " Repeat data entry\n" << std::endl;
        }
        catch (std::invalid_argument) {
            std::cout << "\nError: Invalid input format. Repeat data entry\n" << std::endl;
        } 
        catch (...) {
            std::cout << "\nUnknown error. Repeat data entry\n" << std::endl;
        }
    }
    uiManager.printData();
    std::cout << std::endl;
}
