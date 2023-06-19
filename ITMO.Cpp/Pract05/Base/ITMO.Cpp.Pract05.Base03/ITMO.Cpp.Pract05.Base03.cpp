#include <iostream>
#include <windows.h>

using std::cout;
using std::cin;
using std::swap;

void show_array(const int[], const int);
bool from_min(const int, const int);
bool from_max(const int, const int);
void bubble_sort(int arr[], const int n, bool (*compare)(int a, int b));
int* input_array(int);

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    int my_choose = 0;
    bool (*from_f[2])(int, int) = { from_min, from_max };
    int n;

    cout << "Введите количество элементов массива: ";
    cin >> n;

    int* array = input_array(n);

    cout << "1. Сортировать по возрастанию\n";
    cout << "2. Сортировать по убыванию\n";
    cin >> my_choose;
    cout << "Исходные данные: ";

    show_array(array, n);

    /*switch (my_choose)
    {
        case 1: 
            bubble_sort(array, n, from_min); 
            break;
        case 2: 
            bubble_sort(array, n, from_max); 
            break;
        default: 
            cout << "\rНеизвестная операция ";
    }*/

    bubble_sort(array, n, (*from_f[my_choose - 1]));

    show_array(array, n);

    delete []array;

    return 0;
}

int* input_array(int count) {
    int* myArray = new int[count];

    cout << "Введите элементы массива: ";
    for (int i = 0; i < count; i++) {
        cin >> myArray[i];
    }

    return myArray;
}

void show_array(const int arr[], const int n) {
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }
    cout << "\n";
}

bool from_min(const int a, const int b) {
    return a > b;
}

bool from_max(const int a, const int b) {
    return a < b;
}

void bubble_sort(int arr[], const int n,
                 bool (*compare)(int a, int b)) {
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if ((*compare)(arr[j], arr[j + 1])) {
                swap(arr[j], arr[j + 1]);
            }
        }
    }
}




















