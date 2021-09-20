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
	cout<<"������� ������ ����������� ����� - ";
	cin>>a;
	if (a < 1)
	{
		cout<<"������ ����� �� ��������� �����������.";
		return 11;
	}
	cout<<"������� ������ ����������� ����� - ";
	cin>>b;
	if (b < 1)
	{
		cout<<"������ ����� �� ��������� �����������.";
		return 11;
	}
	sr_1 = quantity (a);
	sr_2 = quantity (b);
	cout<<"���������� ���� '5' � ������ ����� - "<<sr_1<<endl;
	cout<<"���������� ���� '5' �� ������ ����� - "<<sr_2<<endl;
	if (sr_1 > sr_2) cout<<"������ ����� �������� ������ ���� '5'.";
	if (sr_1 < sr_2) cout<<"������ ����� �������� ������ ���� '5'.";
	if (sr_1 == sr_2) cout<<"��� ����� �������� ������ ���������� ���� '5'.";
	return 0;
}

