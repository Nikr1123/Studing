#include <iostream>
#include <windows.h>
#include <iomanip>
#include <string>

using namespace std;

double summ (double x1, double x2)
{
	double s;
	s = x1 + x2;
	return s;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	double a, b, c;
	cout<<"������� 3 ����� - ";
	cin>>a>>b>>c;
	cout<<a<<" + "<<b<<" + "<<c<<" = "<<summ (summ (a, b), c);
	return 0;
}

