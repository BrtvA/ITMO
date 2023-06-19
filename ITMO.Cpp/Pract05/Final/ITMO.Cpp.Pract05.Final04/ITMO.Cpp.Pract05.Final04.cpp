#include <iostream>
#include <string>
#include <cstring>
#include <vector>

int* inputValue(int&, int&);
void split(const std::string&,
           std::vector<std::string>&);
int* sum(int, int);
int* mul(int, int);
int* doAction(int* (*action[2])(int, int), int*, int, int);

int main() {
    //input format: nameProg –a 12 45

    int value1;
    int value2;
    int* (*action[2])(int, int) = { sum, mul };

    int* status = inputValue(value1, value2);

    if (*status >= 0) {
        int* res = doAction(action, status, value1, value2);
        std::cout << "Result: " << *res << std::endl;

        delete res;
    }
    else {
        std::cout << "Error" << std::endl;
    }

    delete status;
}

int* inputValue(int& value1, int& value2) {
    const char* fFlagA = "-a";
    const char* fFlagM = "-m";
    const char* fProgName = "nameProg";
    std::string inputStr;
    std::vector<std::string> arrStr;

    std::cout << "Enter options: ";
    std::getline(std::cin, inputStr);
    
    split(inputStr, arrStr);

    int temp = std::strncmp(arrStr[1].c_str(), fFlagA, 2);

    if (arrStr.size() != 4
        || std::strncmp(arrStr[0].c_str(), fProgName, 8) != 0
        || (temp != 0 && std::strncmp(arrStr[1].c_str(), fFlagM, 2) != 0)) {
        return new int(-999);
    }
    else {
        value1 = std::atoi(arrStr[2].c_str());
        value2 = std::atoi(arrStr[3].c_str());
        return new int(temp);
    }
}

void split(const std::string& str,
    std::vector<std::string>& arrStr) {
    int index = 0;
    int len = str.size();
    int count;

    for (int i = 0; i < len; i++) {
        if (str[i] == ' ' || i == len - 1) {
            count = i - index;
            arrStr.push_back(str.substr(index, count > 0 ? count : 1));
            index = i + 1;
        }
    }
}

int* doAction(int *(*action[2])(int, int), int *status, int value1, int value2) {
    return (*action[*status])(value1, value2);
}

int* sum(int value1, int value2) {
    return new int(value1 + value2);
}

int* mul(int value1, int value2) {
    return new int(value1 * value2);
}
