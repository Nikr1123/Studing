#include <iostream>
#include <fstream>
#include <windows.h>
#include <iomanip>

using namespace std;

int read (char* s)
{
	int sc = 0;
	ifstream file(s);
	if (file.is_open())
	{
		int x;
		while (!file.eof())
		{
			file>>x;
			if (!file.eof())
			{
				cout<<x<<" ";
				sc ++;
			}
		}
		file.close();
	}
	else cout<<"Невозмоожно открыть файл."<<endl;
	return sc;
};

void write (char* in, char* out, int sc)
{
	if (sc > 6)
	{
		bool check = false;
		ifstream file_in(in);
		if (file_in.is_open())
		{
			ofstream file_out(out);
			if (file_out.is_open())
			{
				int x, k = 0;
				check = true;
				while (!file_in.eof())
				{
					file_in>>x;
					if (!file_in.eof())
					{
						int arc = x;
						if (k != 5)	file_out<<x<<" ";
						else
						{
							cout<<endl;
							for (int i = 0 ; i < 3; i ++)
							{
								cout<<"Введите "<<i + 6<<"-ое число - ";
								cin>>x;
								file_out<<x<<" ";
							}
							file_out<<arc<<" ";
						} 
						k ++;
					}
				}
				cout<<endl;
			}
			file_out.close();
		}
		file_in.close();
		if (check == false) cout<<"Невозмоожно открыть файл.";
		else
		{
			ifstream file_a(out);
			ofstream file_b(in);
			while (!file_a.eof())
			{
				int x;
				file_a>>x;
				if (!file_a.eof())
				{
					file_b<<x<<" ";
				}
			}
			file_a.close();
			file_b.close();
		}
	}
	else cout<<"В файле менее 8 элементов";
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int sc;
	char* name_in = "f.txt";
	char* name_out = "g.txt";
	cout<<"В файле f.txt записанны числа:"<<endl;
	sc = read(name_in);
	write(name_in, name_out, sc);
	cout<<"В файле f.txt записанны слова:"<<endl;
	sc = read(name_out);
	return 0;
}
