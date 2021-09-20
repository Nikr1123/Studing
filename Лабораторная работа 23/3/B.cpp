#include <iostream>
#include <fstream>
#include <windows.h>
#include <iomanip>

using namespace std;

int read (char* s)
{
	ifstream file(s);
	int n = 0;
	if (file.is_open())
	{
		int x;
		while (!file.eof())
		{
			file>>x;
			if (!file.eof())
			{
				cout<<x<<" ";
				n++;
			}
		}
		file.close();
	}
	else cout<<"Невозмоожно открыть файл."<<endl;
	return n;
};

void write (char* in, char* out, int size)
{
	ifstream file_in(in);
	int ark[size];
	int k = 0;
	if (file_in.is_open())
	{
		int x, temp_1, temp_2;
		while (!file_in.eof())
		{
			file_in>>x;
			if (!file_in.eof())
			{
				if ((k != 2) || (k != size)) ark[k] = x;
				if (k == 2) temp_1 = x;
				if (k == size-1) temp_2 = x;
				k ++;
			}
		}
		file_in.close();
		ark[2] = temp_2;
		ark[size-1] = temp_1;
		ofstream file_out(out);
		if (file_out.is_open())
		{
			for (int j = 0 ; j < k ; j ++)
			{
				file_out<<ark[j]<<" ";
			}
			file_out.close();
		}
		else cout<<"Невозмоожно открыть файл."<<endl;
	}
	else cout<<"Невозмоожно открыть файл."<<endl;
};

void owerwrite (char* in, char* out)
{
	ifstream file_in(in);
	if (file_in.is_open())
	{
		ofstream file_out(out);
		if (file_in.is_open())
		{
			int x;
			while (!file_in.eof())
			{
				file_in>>x;
				if (!file_in.eof())
				{
					file_out<<x<<" ";
				}
			}
		}
		else cout<<"Невозмоожно открыть файл."<<endl;
		file_out.close();
	}
	else cout<<"Невозмоожно открыть файл."<<endl;
	file_in.close();
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char* name_in = "f.txt";
	char* name_out = "g.txt";
	int n;
	cout<<"В файле f.txt записанны числа:"<<endl;
	n = read(name_in);
	write (name_in, name_out, n);
	owerwrite (name_out, name_in);
	cout<<endl<<"Теперь в файле f.txt записанны числа:"<<endl;
	n = read(name_out);
	return 0;
}
