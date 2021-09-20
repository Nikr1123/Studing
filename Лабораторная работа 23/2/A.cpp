#include <iostream>
#include <fstream>
#include <string>
#include <windows.h>

using namespace std;

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int last_id;
	cout<<"������� ����� ����� ������ � ���� - ";
	cin>>last_id;
	if (last_id < 1)
	{
		cout<<"������ ������ ����� 1 �����.";
		return 11;
	}
	double range_min;
	cout<<"������� ������ ������� ��������� ����� - ";
	cin>>range_min;
	double range_max;
	cout<<"������� ������� ������� ��������� ����� - ";
	cin>>range_max;
	if (range_max < range_min)
	{
		cout<<"������� ������� ��������� ����� �� ����� ���� ������, ��� ������.";
		return 1;
	}
	ofstream file ("f.txt");
	if (!file.is_open())
	{
		cout<<"���������� ������� ����.";
		return 11;
	}
	double s;
	for (int id = 0 ; id < last_id ; id ++)
	{
		s = range_min + (range_max - range_min) * (double)rand() / (double)RAND_MAX;
		file<<s<<" ";
	}
    file.close();
	cout<<"� ���� f.txt ��������� �������� �����.";
	return 0;
}

