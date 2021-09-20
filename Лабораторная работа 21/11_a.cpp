#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

void Fact (int b)
{
	int K_1 = 0, K_2 = 1, K_3 = 1, K_4;
	while (K_2 <= b)
	{
		K_4 = K_2;
		K_3 = 1;
		while (K_4 > 1)
		{
			K_3 *= K_4;
			K_4 --;
		}
		K_1 += K_3;
		K_2 += 2;
	}
	cout<<K_1;
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
	cout<<"Сумма факториалов нечётных чисел от 1 до "<<k<<" = ";
	Fact (k);
	return 0;
}
