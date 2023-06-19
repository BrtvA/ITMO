#include <iostream>

class Distance {
private:
    int feet;
    float inches;
public:
    // конструктор по умолчанию
    Distance() : feet(0), inches(0.0) { }
    // конструктор с двумя параметрами
    Distance(int ft, float in) : feet(ft), inches(in) { }
    void getdist()
    {
        std::cout << "\nВведите число футов : ";
        std::cin >> feet;
        std::cout << "\nВведите число дюймов : ";
        std::cin >> inches;
    }
    void showdist()
    {
        std::cout << feet << "\' - " << inches << "\"\n";
    }
    Distance operator+ (const Distance&) const;
};

Distance Distance::operator+ (const Distance& d2) const
{
    int f = feet + d2.feet;
    float i = inches + d2.inches;
    if (i >= 12.0)
    {
        i -= 12.0;
        f++;
    }
    return Distance(f, i);
}

int main() {
    Distance dist1, dist2, dist3, dist4;
    dist4 = dist1 + dist2 + dist3;
    std::cout << "\ndist1 = ";
    dist1.showdist();
}