#include <iostream>
#include <windows.h>

int searchTransposition(int[], int, int);
void showArray(int[], int);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    int arr[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int count = sizeof(arr) / sizeof(arr[0]);
    int value = 10;

    showArray(arr, count);

    for (int i = 0; i < count; i++) {
        std::cout << "Индекс числа " << value << ": "
                  << searchTransposition(arr, count, value) << std::endl;
    }

    showArray(arr, count);
}

void showArray(int array[], int count) {
    for (int i = 0; i < count; i++) {
        std::cout << array[i] << '\t';
    }
    std::cout << std::endl;
}

int searchTransposition(int array[], int count, int value) {
    int index;

    for (int i = 0; i < count; i++) {
        if (array[i] == value) {
            index = i;
            if (index != 0) {
                std::swap(array[i], array[i - 1]);
            }
            return index;
        }
    }

    return -999;
}