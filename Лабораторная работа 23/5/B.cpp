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
		string x;
		while (!file.eof())
		{
			getline(file, x);
			if (!file.eof())
			{
				cout<<x<<" ";
			}
		}
		file.close();
	}
	else cout<<"Невозмоожно открыть файл."<<endl;
};

void write (char* in, char* out)
{
	bool check = false;
	ifstream file_in(in);
	if (file_in.is_open())
	{
		ofstream file_out(out);
		if (file_out.is_open())
		{
			string x;
			check = true;
			while (!file_in.eof())
			{
				getline(file_in, x);
				if (!file_in.eof())
				{
					if ((x.length() == 5) || (x.length() == 6))
					{
						file_out<<x<<endl;
					}
				}
			}
		}
		file_out.close();
	}
	if (check == false) cout<<"Невозмоожно открыть файл.";
	file_in.close();
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	char* name_in = "f.txt";
	char* name_out = "g.txt";
	cout<<"В файле f.txt записанны слова:"<<endl;
	read(name_in);
	write(name_in, name_out);
	cout<<endl<<"В файле g.txt переписаны те слова из файла f.txt, которые состоят из 5 или 6 букв."<<endl;
	cout<<"В файле g.txt записанны слова:"<<endl;
	read(name_out);
	return 0;
}
