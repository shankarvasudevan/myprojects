#include "hello.h"

Hello::Hello() : mMessage("Hello") {}

const std::string Hello::say_hello()
{
	return mMessage;
} 
