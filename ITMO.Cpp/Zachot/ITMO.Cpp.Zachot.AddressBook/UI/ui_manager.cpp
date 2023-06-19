#include "ui_manager.h"

UIManager::UIManager(std::vector<Human*> &pers) : persons(pers), humanFactory(nullptr)
{}

UIManager::~UIManager() {
    if (saveData()) {
        std::cout << "The data was successfully written to the file" << std::endl;
    }
    else {
        std::cout << "Writing to file failed" << std::endl;
    }

    for (auto item = UIManager::persons.begin(); item != UIManager::persons.end(); ++item) {
        delete *item;
    }
    delete UIManager::humanFactory;
}

void UIManager::inputData() {
    std::string lastName;
    std::string name;
    int humanType;
    std::string email;
    std::string line;

    std::cout << "Enter your last name => ";
    std::cin >> lastName;
    std::cout << "Enter your name => ";
    std::cin >> name;
    std::cout << "Enter your email => ";
    std::cin >> email;
    std::cout << "Enter the type of person: lecturer/student [0/1] => ";
    std::cin >> humanType;

    if (humanType > 1 || humanType < 0) {
        throw std::invalid_argument("Error");
    } else if (humanType == 0) {
        std::vector<Time> timeVector;
        std::string phoneNumber;

        std::cout << "Enter your phone number => ";
        while (std::cin.get() != '\n');
        std::getline(std::cin, phoneNumber);

        bool isContinue = true;
        while(isContinue) {
            std::cout << "Enter your working hours ('/' - stop char) => ";

            for (int i = 0; i < 2; i++) {
                std::cin >> line;
                if (line.find(UIManager::STOP_CHAR) == std::string::npos) {
                    auto timeComponents = UIManager::split(line, UIManager::TIME_DELIMITER);
                    Time time(std::stoi(timeComponents[0]),
                              std::stoi(timeComponents[1]));
                    timeVector.push_back(time);
                } else {
                    isContinue = false;
                    if (timeVector.size() % 2 != 0) {
                        timeVector.erase(timeVector.end() - 1);
                    }
                    break;
                }
            }
        }

        UIManager::humanFactory = new LecturerFactory(lastName, name, email,
                                                      phoneNumber, timeVector);
    } else {
        std::vector<int> scoreVector;

        while(true){
            std::cout << "Enter your grade ('/' - stop char) => ";
            std::cin >> line;

            if (line.find(UIManager::STOP_CHAR) == std::string::npos) {
                scoreVector.push_back(std::stoi(line));
            } else {
                if (scoreVector.size() == 0) {
                    scoreVector.push_back(0);
                }
                break;
            }
        }

        UIManager::humanFactory = new StudentFactory(lastName, name, email, scoreVector);
    }

    UIManager::persons.push_back(humanFactory->create());
}

void UIManager::printData() {
    for (const auto &item : UIManager::persons) {
        std::cout << item->toString() << std::endl;
    }
}

bool UIManager::saveData() {
    std::ofstream file(UIManager::FILE_NAME);
    if (!file) {
        std::cout << "Writing to file failed" << std::endl;
        return false;
    }

    for (const auto& item : UIManager::persons) {
        file << item->toString() << std::endl;
    }

    file.close();
    return true;
}

std::vector<std::string> UIManager::split(std::string line, const char delimeter) {
    size_t idx = line.find(delimeter);
    std::vector<std::string> lineVector;
    lineVector.push_back(line.substr(0, idx));
    lineVector.push_back(line.substr(idx+1, line.size() - idx));
    return lineVector;
}
