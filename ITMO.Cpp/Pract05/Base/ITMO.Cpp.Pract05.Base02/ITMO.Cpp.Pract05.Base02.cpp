#include <iostream>

using std::cout;
using std::cin;

int* input_array(int);

int main() {
    int min = 0; // для записи минимального значения
    int buf = 0; // для обмена значениями
    int n;

    cout << "Enter the number of array elements: ";
    cin >> n;

    int *a = input_array(n);

    for (int i = 0; i < n; i++)
    {
        min = i; // номер текущей ячейки, как ячейки с минимальным значением
        // в цикле найдем реальный номер ячейки с минимальным значением
        for (int j = i + 1; j < n; j++)
            min = (a[j] < a[min]) ? j : min;
        // перестановка этого элемента, поменяв его местами с текущим
        if (i != min)
        {
            buf = a[i];
            a[i] = a[min];
            a[min] = buf;
        }
    }

    for (int i = 0; i < n; i++) {
        cout << *(a+i) << '\t';
    }

    delete []a;
}

int* input_array(int count) {
    int* myArray = new int[count];

    cout << "Enter array elements: ";
    for (int i = 0; i < count; i++) {
        cin >> myArray[i];
    }

    return myArray;
}
