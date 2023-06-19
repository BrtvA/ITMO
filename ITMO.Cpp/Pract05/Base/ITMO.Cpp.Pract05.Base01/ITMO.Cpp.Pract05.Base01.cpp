#include <iostream>

using std::cout;
using std::cin;
using std::endl;

int* input_array(int);

int main() {
    int n;
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

    cout << "Enter the number of array elements: ";
    cin >> n;

    int* mas = input_array(n);

    for (int i = 0; i < n; i++)
    {
        s += mas[i];

        if (mas[i] > 0) {
            sumPositive += mas[i];
        }
        else if (mas[i] < 0) {
            sumNegative += mas[i];
        }

        if (i % 2 == 0) {
            sumEven += mas[i];
        }
        else {
            sumOdd += mas[i];
        }

        if (i == 0) {
            maxValue = mas[i];
            minValue = mas[i];
            minIndex = i;
            maxIndex = i;
        }
        else {
            if (mas[i] > maxValue) {
                maxValue = mas[i];
                maxIndex = i;
            }
            if (mas[i] < minValue) {
                minValue = mas[i];
                minIndex = i;
            }
        }
    }

    for (int i = minIndex; i <= maxIndex; i++) {
        mulBetween *= mas[i];
    }

    avg = static_cast<double>(s)/n;

    delete []mas;

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

int* input_array(int count) {
    int* myArray = new int[count];

    cout << "Enter array elements: ";
    for (int i = 0; i < count; i++) {
        cin >> myArray[i];
    }

    return myArray;
}