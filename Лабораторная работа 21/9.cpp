#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

double F (double u, double t)
{
	if ((u > 0) && (t > 0))	return 3 * u + t;
	if ((u > 0) && (t <= 0)) return 5 * u - t;
	if (u <= 0)	return 2 * u - sin (t);
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double a, b, z, f_1, f_2;
	cout<<"¬ведите значени€ A и B - ";
	cin>>a>>b;
	f_1 = F (a - b, 2 * b);
	f_2 = F (a * a + b, b * b * b - 1);
	z = f_1 + f_2;
	cout<<"z = f(a-b, 2b) + f(a^2+b, b^3-1) = "<<z;
	return 0;
}
