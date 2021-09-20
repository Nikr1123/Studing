#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

int quantity (int x)
{
	int i = 0;
	while (x > 0)
	{
		if ((x % 10) == 5)	i++;
		x /= 10;
	}
	return i;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a, b;
	int sr_1, sr_2;
	cout<<"Введите первое натуральное число - ";
	cin>>a;
	if (a < 1)
	{
		cout<<"Первое число не являеться натуральным.";
		return 11;
	}
	cout<<"Введите второе натуральное число - ";
	cin>>b;
	if (b < 1)
	{
		cout<<"Второе число не являеться натуральным.";
		return 11;
	}
	sr_1 = quantity (a);
	sr_2 = quantity (b);
	cout<<"Количество цифр '5' в первом числе - "<<sr_1<<endl;
	cout<<"Количество цифр '5' во втором числе - "<<sr_2<<endl;
	if (sr_1 > sr_2) cout<<"Первое число содержит больше цифр '5'.";
	if (sr_1 < sr_2) cout<<"Второе число содержит больше цифр '5'.";
	if (sr_1 == sr_2) cout<<"Оба числа содержат равное количество цифр '5'.";
	return 0;
}

