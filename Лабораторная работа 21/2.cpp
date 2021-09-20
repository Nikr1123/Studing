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
	cout<<"������� 2 ���������� ����� - ";
	cin>>a>>b;
	if ((a > 999) || (a < 100))
	{
		cout<<"������ ����� �� ��������� �����������.";
		return 11;
	}
	if ((b > 999) || (b < 100))
	{
		cout<<"������ ����� �� ��������� �����������.";
		return 12;
	}
	sr_1 = sr (a);
	sr_2 = sr (b);
	if (sr_1 > sr_2) cout<<"���������� ������� �����: "<<sr_1;
	if (sr_1 < sr_2) cout<<"���������� ������� �����: "<<sr_2;
	if (sr_1 == sr_2) cout<<"������� ����� ����� ����� �����";
	return 0;
}

