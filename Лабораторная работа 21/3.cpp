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
	cout<<"������� ������ �������  ����� - ";
	cin>>a;
	if (a < 0)
	{
		cout<<"������ �� ����� ���� ������ 0.";
		return 11;
	}
	cout<<"������� ������ ������� ����� - ";
	cin>>b;
	if (b < 0)
	{
		cout<<"������ �� ����� ���� ������ 0.";
		return 12;
	}
	cout<<"������� �������  ����� = "<<S (a)<<endl;
	cout<<"������� �������  ����� = "<<S (b)<<endl;
	if (S (a) > S (b)) cout<<"������� ������  ����� ������.";
	if (S (a) < S (b)) cout<<"������� ������� ����� ������.";
	if (S (a) == S (b)) cout<<"������� ����� ������ �����.";
	return 0;
}

