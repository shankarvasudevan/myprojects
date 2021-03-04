#include <iostream>

int main(int argc, char* argv[])
{
	int x=1;
	int y=1;

	std::cout << "x=" << x << std::endl;
	std::cout << "y=" << y << std::endl;

	x++;
	++y;

	std::cout << "x=" << x << std::endl;
	std::cout << "y=" << y << std::endl;
	
	return 0;
}
