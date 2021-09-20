#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

int fact (int a)
{
	int N_1 = a;
	if (a > 1)
	{
		a *= fact (N_1 - 1);
	}
	return a;
};

int sum (int b)
{
	int K_1 = b;
	if (b > 1)
	{
		b = fact (b);
		b += sum (K_1 - 2);
	}
	return b;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int k;
	cout<<"Введите значение k - ";
	cin>>k;
	if (k < 1)
	{
		cout<<"Значение k должно быть больше 0.";
		return 21;
	}
	if (k % 2 == 0)
	{
		cout<<"Значение k должно быть нечётным.";
		return 22;
	}
	cout<<"Сумма факториалов нечётных чисел от 1 до "<<k<<" = "<<sum(k);
	return 0;
}
