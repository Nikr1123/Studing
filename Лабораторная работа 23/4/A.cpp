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
		cout<<"������ ������ ����� 1 ��������.";
		return 11;
	}
	int range_min;
	cout<<"������� ���������� ��������� ����� - ";
	cin>>range_min;
	int range_max;
	cout<<"������� ����������� ��������� ����� - ";
	cin>>range_max;
	if (range_min > range_max)
	{
		cout<<"���������� ��������� ����� �� ����� ���� ������ ����������� ����������.";
		return 21;
	}
	ofstream file ("f.txt");
	if (!file.is_open())
	{
		cout<<"���������� ������� ����.";
		return 11;
	}
	for (int id = 0 ; id < last_id ; id ++)
	{
		int gen = rand() % (range_max - range_min + 1) + range_min;
		file<<gen<<" ";
	}
    file.close();
	cout << "� ���� ��������� ��������������� �����.";
	return 0;
}

