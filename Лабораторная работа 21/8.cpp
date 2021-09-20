#include <iostream>
#include <windows.h>
#include <cstdlib>
#include <time.h>

using namespace std;

void input_mass (int mass[], int range_in, int range_a, int range_b)
{
	int i_in = 0;
	for (i_in ; i_in < range_in ; i_in ++)
	mass[i_in] = rand() % (range_b - range_a + 1) + range_a;
};

void output_mass (int mass[], int range_out)
{
	int i_out = 0;
	for (i_out ; i_out < range_out ; i_out ++)
	cout<<mass[i_out]<<" ";
};

void input_max (int mass_a[], int mass_b[], int mass_c[], int range_max)
{
	int i_max = 0;
	for (i_max ; i_max < range_max ; i_max ++)
	{
		if (mass_a[i_max] > mass_b[i_max])	mass_c[i_max] = mass_a[i_max];
		if (mass_a[i_max] < mass_b[i_max])	mass_c[i_max] = mass_b[i_max];
		if (mass_a[i_max] == mass_b[i_max])	mass_c[i_max] = mass_a[i_max];
	}
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int id, last_id, range_min, range_max;
	cout<<"Введите количество элементов в массивах - ";
	cin>>last_id;
	if (last_id < 0)
	{
		cout<<"Количество элементов в массивах не может быть меньше 0";
		return 11;
	}
	cout<<"Введите диапазон значений массива - ";
	cin>>range_min>>range_max;
	if (range_min > range_max)
	{
		cout<<"Неверно задан диапазон значений массива.";
		return 12;
	}
	last_id ++;
	int a[last_id], b[last_id], c[last_id];
	last_id --;
	input_mass(a, last_id, range_min, range_max);
	input_mass(b, last_id, range_min, range_max);
	cout<<"Первый массив из "<<last_id<<" целых чисел в диапазоне от "<<range_min<<" до "<<range_max<<":"<<endl;
	output_mass(a, last_id);
	cout<<endl<<"Второй массив из "<<last_id<<" целых чисел в диапазоне от "<<range_min<<" до "<<range_max<<":"<<endl;
	output_mass(b, last_id);
	cout<<endl<<"Третий массив, составленный по правилу: каждый элемент нового массива есть наибольший из соответствующих элементов данных массивов:"<<endl;
	input_max (a, b, c, last_id);
	output_mass(c, last_id);
	return 0;
}
