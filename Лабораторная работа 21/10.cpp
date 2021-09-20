#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

int F (int X)
{
	if ((X / 10) % 10 != 0)
	{
		if (X % ((X / 10) % 10) == 0)	return X;
	}
	else 	return 0;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int N, i = 0;
	cout<<"Введите значение N - ";
	cin>>N;
	if (N < 10)
	{
		cout<<"Значение N должно быть больше 10.";
		return 11;
	}
	cout<<"натуральные числа, не превосходящие "<<N<<" делящиеся на свою 2 справа цифру: ";
	for (int n = 10 ; n <= N ; n ++)
	{
		if (F(n) != 0) cout<<F(n)<<" ";
		else i++;
	}
	if (i == N) cout<<"Отсутствуют.";
	return 0;
}
