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
	cout<<"������� ���� ����� ������ � ���� - ";
	cin>>last_id;
	if (last_id < 1)
	{
		cout<<"������ ������ ����� 1 �����.";
		return 11;
	}
	ofstream file ("f.txt");
	if (!file.is_open())
	{
		cout<<"���������� ������� ����.";
		return 11;
	}
	string s;
	for (int id = 0 ; id < last_id ; id ++)
	{
		cout<<"������� "<<id + 1<<"-�� ����� - ";
		cin>>s;
		file<<s<<endl;
	}
    file.close();
	cout<<"� ���� f.txt ��������� �������� �����.";
	return 0;
}

