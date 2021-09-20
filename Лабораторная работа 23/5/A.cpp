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
	cout<<"Сколько слов нужно ввести в файл - ";
	cin>>last_id;
	if (last_id < 1)
	{
		cout<<"Нельзя ввести менее 1 слова.";
		return 11;
	}
	ofstream file ("f.txt");
	if (!file.is_open())
	{
		cout<<"Невозможно открыть файл.";
		return 11;
	}
	string s;
	for (int id = 0 ; id < last_id ; id ++)
	{
		cout<<"Введите "<<id + 1<<"-ое слово - ";
		cin>>s;
		file<<s<<endl;
	}
    file.close();
	cout<<"В файл f.txt добавлены введённые слова.";
	return 0;
}

