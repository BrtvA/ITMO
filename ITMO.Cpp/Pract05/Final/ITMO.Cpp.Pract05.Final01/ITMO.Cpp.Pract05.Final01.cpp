#include <iostream>

using std::cout;
using std::cin;
using std::endl;

int* input_array(int);
void showArrayOptions(int[], int);
void sortArray(int[], int);
void showArray(int[], int);

int main() {
    int count;

    cout << "Enter the number of array elements: ";
    cin >> count;

    cout << "------------" << endl;
    int* arr = input_array(count);

    cout << "------------" << endl;
    showArrayOptions(arr, count);

    cout << "------------" << endl;
    sortArray(arr, count);
    cout << "Sorted array: " << endl;
    showArray(arr, count);

    delete []arr;
}

int* input_array(int count) {
    int* myArray = new int[count];

    cout << "Enter array elements: ";
    for (int i = 0; i < count; i++) {
        cin >> myArray[i];
    }

    return myArray;
}

void showArray(int array[], int count) {
    for (int i = 0; i < count; i++) {
        cout << array[i] << '\t';
    }
}

void sortArray(int array[], int count) {
    int min = 0; // для записи минимального значения
    int buf = 0; // для обмена значениями

    for (int i = 0; i < count; i++)
    {
        min = i; // номер текущей ячейки, как ячейки с минимальным значением
        // в цикле найдем реальный номер ячейки с минимальным значением
        for (int j = i + 1; j < count; j++)
            min = (array[j] < array[min]) ? j : min;
        // перестановка этого элемента, поменяв его местами с текущим
        if (i != min)
        {
            buf = array[i];
            array[i] = array[min];
            array[min] = buf;
        }
    }
}

void showArrayOptions(int array[], int count) {
    double avg;
    int s = 0;
    int sumNegative = 0;
    int sumPositive = 0;
    int sumEven = 0;
    int sumOdd = 0;
    int mulBetween = 1;
    int maxValue;
    int minValue;
    int maxIndex;
    int minIndex;

    for (int i = 0; i < count; i++)
    {
        s += array[i];

        if (array[i] > 0) {
            sumPositive += array[i];
        }
        else if (array[i] < 0) {
            sumNegative += array[i];
        }

        if (i % 2 == 0) {
            sumEven += array[i];
        }
        else {
            sumOdd += array[i];
        }

        if (i == 0) {
            maxValue = array[i];
            minValue = array[i];
            minIndex = i;
            maxIndex = i;
        }
        else {
            if (array[i] > maxValue) {
                maxValue = array[i];
                maxIndex = i;
            }
            if (array[i] < minValue) {
                minValue = array[i];
                minIndex = i;
            }
        }
    }

    for (int i = minIndex; i <= maxIndex; i++) {
        mulBetween *= array[i];
    }

    avg = static_cast<double>(s) / count;

    cout << "Summary: " << s << endl;
    cout << "Average: " << avg << endl;
    cout << "Sum of positive elements: " << sumPositive << endl;
    cout << "Sum of negative elements: " << sumNegative << endl;
    cout << "Sum of elements with even indices: " << sumEven << endl;
    cout << "Sum of elements with odd indices: " << sumOdd << endl;
    cout << "Maximum element: " << maxValue << ". Index: " << maxIndex << endl;
    cout << "Minimum element: " << minValue << ". Index: " << minIndex << endl;
    cout << "Multiply elements between indices: " << mulBetween << endl;
}