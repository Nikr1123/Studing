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
	cout<<"������� �������� k - ";
	cin>>k;
	if (k < 1)
	{
		cout<<"�������� k ������ ���� ������ 0.";
		return 21;
	}
	if (k % 2 == 0)
	{
		cout<<"�������� k ������ ���� ��������.";
		return 22;
	}
	cout<<"����� ����������� �������� ����� �� 1 �� "<<k<<" = "<<sum(k);
	return 0;
}
