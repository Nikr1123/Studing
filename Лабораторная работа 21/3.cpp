#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

double S (double x)
{
	return M_PI * x * x;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double a, b;
	cout<<"Введите радиус первого  круга - ";
	cin>>a;
	if (a < 0)
	{
		cout<<"Радиус не может быть меньше 0.";
		return 11;
	}
	cout<<"Введите радиус второго круга - ";
	cin>>b;
	if (b < 0)
	{
		cout<<"Радиус не может быть меньше 0.";
		return 12;
	}
	cout<<"Площадь первого  круга = "<<S (a)<<endl;
	cout<<"Площадь второго  круга = "<<S (b)<<endl;
	if (S (a) > S (b)) cout<<"Площадь первой  круга больше.";
	if (S (a) < S (b)) cout<<"Площадь второго круга больше.";
	if (S (a) == S (b)) cout<<"Площади обоих кругов равны.";
	return 0;
}

