#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

int sr (int x)
{
	return (x / 10) % 10;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int a, b;
	int sr_1, sr_2;
	cout<<"Введите 2 трёхзначных числа - ";
	cin>>a>>b;
	if ((a > 999) || (a < 100))
	{
		cout<<"Первое число не являеться трйхзначным.";
		return 11;
	}
	if ((b > 999) || (b < 100))
	{
		cout<<"Второе число не являеться трйхзначным.";
		return 12;
	}
	sr_1 = sr (a);
	sr_2 = sr (b);
	if (sr_1 > sr_2) cout<<"Наибольшая средняя цифра: "<<sr_1;
	if (sr_1 < sr_2) cout<<"Наибольшая средняя цифра: "<<sr_2;
	if (sr_1 == sr_2) cout<<"Средние цифры обоих чисел равны";
	return 0;
}

