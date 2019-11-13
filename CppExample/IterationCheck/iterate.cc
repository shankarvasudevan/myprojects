#include <iostream>


int main()
{
	for (std::size_t i=0; i < 10; i++)
	{
		std::cout << "i=" << i << std::endl;
	}

	for (std::size_t j=0; j < 10; ++j)
	{
		std::cout << "j=" << j << std::endl;
	}

	return 0;
}
