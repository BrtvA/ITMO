#include <iostream>
#include <windows.h>

using std::cout;
using std::cin;
using std::ends;

struct Distance
{
    int feet;
    double inches;

    void ShowDist()
    {
        cout << feet << "\'-" << inches << "\"\n";
    }
};

Distance AddDist(const Distance& d1, const Distance& d2)
{
    Distance d;
    d.feet = d1.feet + d2.feet;
    d.inches = d1.inches + d2.inches;
    if (d.inches >= 12.0)
    {
        d.inches -= 12.0;
        d.feet++;
    }
    return d;
}

Distance InputDist()
{
    Distance d;
    cout << "\nВведите число футов: ";
    cin >> d.feet;
    cout << "Введите число дюймов: ";
    cin >> d.inches;
    return d;
}

int main() {
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    Distance d1 = InputDist();
    Distance d2 = { 1, 6.25 };
    Distance d3 = AddDist(d1, d2);

    d1.ShowDist();
    d2.ShowDist();
    d3.ShowDist();

    int n;
    cout << "Введите размер массива расстояний ";
    cin >> n;

    Distance* masDist = new Distance[n];
    Distance sum = { 0, 0 };

    for (int i = 0; i < n; i++)
    {
        masDist[i] = InputDist();
    }

    for (int i = 0; i < n; i++)
    {
        masDist[i].ShowDist();
        sum.feet += masDist[i].feet;
        sum.inches += masDist[i].inches;
    }

    cout << "Сумма: " << ends;
    sum.ShowDist();

    delete[] masDist;

    return 0;
}