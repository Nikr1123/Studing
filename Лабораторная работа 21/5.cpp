#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

boolean check (double x_1, double x_2, double x_3)
{
	if ((x_1 + x_2 > x_3) && (x_1 + x_2 > x_3) && (x_2 + x_3 > x_1) && (x_1 > 0) && (x_2 > 0) && (x_3 > 0))	return true;
	else return false;
};

void S (double x1, double x2, double x3)
{
	double s = 0, p = 0;
	p = (x1 + x2 + x3) / 2;
	s = sqrt (p * (p - x1) * (p - x2) * (p - x3));
	cout<<"Площадь треугольника со сторонами "<<x1<<", "<<x2<<", "<<x3<<" = "<<s<<endl;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int i = 0;
	double a, b, c, d;
	double s1 = 0, s2 = 0, s3 = 0, s4 = 0;
	cout<<"Введите длины 4 отрезков - ";
	cin>>a>>b>>c>>d;
	if (check (a, b, c))
	{
		S (a, b, c);
		i++;
	}
	if (check (a, b, d))
	{
		S (a, b, d);
		i++;
	}
	if (check (a, c, d))
	{
		S (a, c, d);
		i++;
	}
	if (check (b, c, d))
	{
		S (b, c, d);
		i++;
	}
	if (i == 0) cout<<"Невозможно составить ниодного треугольника.";
	return 0;
}
