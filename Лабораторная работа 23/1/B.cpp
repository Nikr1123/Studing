#include <iostream>
#include <fstream>
#include <windows.h>
#include <iomanip>

using namespace std;


int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	cout<<"� ����� �������� �����:"<<endl;
	ifstream file ("f.txt");
	int positiv = 0, negativ = 0;
	while (!file.eof ())
	{
		if (!file.eof ())
		{
			int x;
			file>>x;
			cout<<x<<setw(3);
			if (x > 0) positiv ++;
			if (x < 0) negativ ++;
		}
	}
	cout<<endl<<"���������� ������������� ����� - "<<positiv<<endl;
	cout<<"���������� ������������� ����� - "<<negativ<<endl;
	if (positiv > negativ) cout<<"� ����� ������ ������������� �����, ��� �������������.";
	if (positiv < negativ) cout<<"� ����� ������ ������������� �����, ��� �������������.";
	if (positiv == negativ) cout<<"������������� � ������������� ����� � ����� �������.";
	return 0;
}

