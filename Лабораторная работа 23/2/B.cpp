#include <iostream>
#include <fstream>
#include <windows.h>
#include <iomanip>

using namespace std;

void read (char* s)
{
	ifstream file(s);
	if (file.is_open())
	{
		double x;
		while (!file.eof())
		{
			file>>x;
			if (!file.eof())
			{
				cout<<x<<" ";
			}
		}
		file.close();
	}
	else cout<<"Невозмоожно открыть файл."<<endl;
};

void write (char* in)
{
	int n = 0;
	double temp_1, temp_2;
	ifstream file(in);
	if (file.is_open())
	{
		double x;
		while (!file.eof())
		{
			file>>x;
			if (!file.eof())
			{
				if (n == 1) temp_1 = x;
				temp_2 = x;
				n ++;
				
			}
		}
	}
	else cout<<"Невозмоожно открыть файл.";
	file.close();
	cout<<endl;
	if (n < 2) cout<<"В файле менее 2 чисел.";
	else
	{
		double sum = temp_1 + temp_2;
		cout<<"Сумма второго и последнего числа = "<<sum;
	}
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char* name_in = "f.txt";
	cout<<"В файле f.txt записанны числа:"<<endl;
	read(name_in);
	write(name_in);
	return 0;
}
