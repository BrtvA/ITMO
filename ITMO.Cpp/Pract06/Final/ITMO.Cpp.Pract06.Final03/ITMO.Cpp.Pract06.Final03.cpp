#include <iostream>
#include <nlohmann/json.hpp>
#include <fstream>
using json = nlohmann::json;

using std::cout;
using std::endl;

int* maxVect(int, int[], int[]);

int main() {
    int a[] = { 1,2,3,4,5,6,7,2 };
    int b[] = { 7,6,5,4,3,2,1,3 };
    int* c;

    int kc = sizeof(a) / sizeof(a[0]);
    c = maxVect(kc, a, b);
    for (int i = 0; i < kc; i++)
        cout << c[i] << " ";
    cout << endl;

    json jsn;
    json arrJsn = json::array();

    for (int i = 0; i < kc; i++) {
        arrJsn.push_back(c[i]);
    }

    jsn["arrayA"] = a;
    jsn["arrayB"] = b;
    jsn["arrayC"] = arrJsn;

    std::cout << std::setw(4) << jsn << std::endl;

    std::ofstream file("array.json");
    if (!file) {
        std::cout << "Writing to file failed" << std::endl;
        return 1;
    }
    file << std::setw(4) << jsn << std::endl;
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