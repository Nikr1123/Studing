#include <iostream>
#include <fstream>
#include <windows.h>
#include <iomanip>

using namespace std;


int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	bool check = false;
	cout<<"В первом файле записанны числа:"<<endl;
	ifstream file_1 ("f.txt");
	ofstream file_2_in ("g.txt");
	while (!file_1.eof ())
	{
		int x;
		file_1>>x;
		if (!file_1.eof ())
		{
			cout<<x<<setw(3);
			if (x > 0)
			{
				file_2_in<<x<<" ";
				check = true;
			}
		}
	}
	file_1.close();
	file_2_in.close();
	cout<<endl;
	if (!check)
	{
		cout<<"В первом файле нет положительных элементов.";
		return 11;
	}
	cout<<"Второй файл, составленный из положительных элементов первого файла:"<<endl;
	ifstream file_2_out ("g.txt");
	while (!file_2_out.eof ())
	{
		int x;
		file_2_out>>x;
		if (!file_2_out.eof ())
		{
			cout<<x<<setw(3);
		}
	}
	file_2_out.close();
	return 0;
}
