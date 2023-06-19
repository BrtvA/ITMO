#include <iostream>
#include <fstream>

using std::cout;
using std::endl;

int* maxVect(int, int[], int[]);

int main() {
    int a[] = { 1,2,3,4,5,6,7,2 };
    int b[] = { 7,6,5,4,3,2,1,3 };
    int kc = sizeof(a) / sizeof(a[0]);
    int* c;
    c = maxVect(kc, a, b);
    for (int i = 0; i < kc; i++)
        cout << c[i] << " ";
    cout << endl;

    std::ofstream file("array.txt");
    if (!file) {
        std::cout << "Writing to file failed" << std::endl;
        return 1;
    }
    for (int i = 0; i < kc; i++) {
        file << a[i] << "\t"
             << b[i] << "\t"
             << c[i] << std::endl;
    }
    file.close();

    delete[]c;

    return 0;
}

int* maxVect(int len, int arr1[], int arr2[]) {
    int* array = new int[len];

    for (int i = 0; i < len; i++) {
        if (arr1[i] > arr2[i]) {
            array[i] = arr1[i];
        }
        else {
            array[i] = arr2[i];
        }
    }

    return array;
}