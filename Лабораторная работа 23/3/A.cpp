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
	cout<<"Сколько чисел нужно ввести в файл - ";
	cin>>last_id;
	if (last_id < 1)
	{
		cout<<"Нельзя ввести менее 1 числа.";
		return 11;
	}
	int range_min;
	cout<<"Введите нижнию границу генерации чисел - ";
	cin>>range_min;
	int range_max;
	cout<<"Введите верхнюю границу генерации чисел - ";
	cin>>range_max;
	if (range_max < range_min)
	{
		cout<<"Верхняя граница генерации чисел не может быть меньше, чем нижняя.";
		return 1;
	}
	ofstream file ("f.txt");
	if (!file.is_open())
	{
		cout<<"Невозможно открыть файл.";
		return 11;
	}
	int s;
	for (int id = 0 ; id < last_id ; id ++)
	{
		s = rand() % (range_max - range_min + 1) + range_min;
		file<<s<<" ";
	}
    file.close();
	cout<<"В файл f.txt добавлены введённые числа.";
	return 0;
}

