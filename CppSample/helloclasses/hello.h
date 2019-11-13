#include <string>

class Hello
{
	public:
		Hello();		
		const std::string say_hello();

	private:
		std::string mMessage;
};
