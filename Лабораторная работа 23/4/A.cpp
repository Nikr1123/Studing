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
		cout<<"Нельзя ввести менее 1 элемента.";
		return 11;
	}
	int range_min;
	cout<<"Введите минимально возможное число - ";
	cin>>range_min;
	int range_max;
	cout<<"Введите максимально возможное число - ";
	cin>>range_max;
	if (range_min > range_max)
	{
		cout<<"Минимально возможное число не может быть больше максимально возможного.";
		return 21;
	}
	ofstream file ("f.txt");
	if (!file.is_open())
	{
		cout<<"Невозможно открыть файл.";
		return 11;
	}
	for (int id = 0 ; id < last_id ; id ++)
	{
		int gen = rand() % (range_max - range_min + 1) + range_min;
		file<<gen<<" ";
	}
    file.close();
	cout << "В файл добавлены сгенерированные числа.";
	return 0;
}

