#include <iostream>
#include <type_traits>

struct Point
{
    Point()
    {
        std::cout << "Constructor" << std::endl;
    }

    Point(const Point& p)
    {
        std::cout << "Copy constructor" << std::endl;
        x = p.x;
        y = p.y;
    }

    ~Point()
    {
        std::cout << "Destructor" << std::endl;
    }

    float x;
    float y;
};

void Print(Point p)
{
    std::cout << "Inside pri nt method" << std::endl;
    p.x += 1;
    p.y += 1;
    std::cout << "x=" << p.x << ", y=" << p.y << std::endl;
}

int main()
{
    //   std::cout << std::is_fundamental_v<Point> << " "
    //         << std::is_fundamental_v<int> << " "
    //         << std::is_compound_v<Point> << " "
    //         << std::is_compound_v<int> << std::endl;

    std::cout << "Start of program" << std::endl;

    Point p;
    p.x = 42;
    p.y = 23;

    std::cout << "Calling Print" << std::endl;

    Print(p);

    std::cout << "Now x=" << p.x << ", y=" << p.y << std::endl;

    std::cout << "End of program" << std::endl;
}
