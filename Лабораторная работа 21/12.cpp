#include <iostream>
#include <windows.h>

using namespace std;

int fib (int i)	
{
	if(i < 2)	return 1;
	else	return fib(i - 1) + fib(i - 2);
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int quantity, n_1 = 0, n_2 = 0, i = 0;
	cout<<"Первые 7 нечётных чисел последовательности Фибоначи:"<<endl;
	while (i != 7)
	{
		if (fib(n_1) % 2 == 1)
		{
			i ++;
		}
		n_2 ++;
		n_1 ++;
	}
	for (n_1 = 0 ; n_1 < n_2 ; n_1 ++)
	{
		if (fib(n_1) % 2 == 1)
		{
			cout<<fib(n_1)<<" ";
		}
	}
	return 0;
}
