/*

#include <iostream>
#include <windows.h>

using namespace std;

int fib (int i)	
{
	if(i < 2) return 1;
	return fib(i-1) + fib(i - 2);
};

int check (int number)
{
	int q = 0;
	for (int i = 1 ; i <= fib(number) ; i ++)
	{
		if (fib(number) > 50)
		{
			if (fib(number) % i == 0) q ++;
		}
	}
	return q;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int id = 0, n;
	cout<<"ѕервый член последовательностти ‘ибоначи, больший 50 и €вл€ющийс€ простым числом: ";
	while (n != 2)
	{
		n = check(id);
		id ++;
	}
	cout<<fib(id - 1);
	return 0;
}

*/

#include <iostream>
#include <windows.h>

using namespace std;

int fib (int i)	
{
	cout<<", i = "<<i<<", fib = "<<fib(i)<<endl;
	if(i < 2) return 1;
	return fib(i-1) + fib(i - 2);
};

int check (int number)
{
	int q = 0, del = 1;
	if	(del <= fib(number))
	{
		if (fib(number) % del == 0) q ++;
		del ++;
	}
	else return q;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int id = 51, n;
	cout<<"ѕервый член последовательностти ‘ибоначи, больший 50 и €вл€ющийс€ простым числом: ";
	while (n != 2)
	{
		n = check(id);
		cout<<"ok"<<endl;
		id ++;
	}
	cout<<fib(id - 1);
	return 0;
}


