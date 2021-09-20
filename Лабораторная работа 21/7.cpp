#include <iostream>
#include <windows.h>
#include <cstdlib>
#include <time.h>

using namespace std;

int max_f (int mass[], int range)
{
	int i;
	if (range == 0) return 0;
	int max = mass[0];
	for (i = 0 ; i < range ; i ++)
	{
		if (mass[i] > max) max = mass[i];
	}
	return max;
};

void input_mass (int mass[], int range_in)
{
	int i_in = 0;
	for (i_in ; i_in < range_in ; i_in ++)
	mass[i_in] = rand() % 31 - 15;
};

void output_mass (int mass[], int range_out)
{
	int i_out = 0;
	for (i_out ; i_out < range_out ; i_out ++)
	cout<<mass[i_out]<<" ";
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int id, last_id_1, last_id_2, max_1, max_2;
	cout<<"������� ���������� ��������� � ������ ������� - ";
	cin>>last_id_1;
	if (last_id_1 < 0)
	{
		cout<<"���������� ��������� � ������ ������� �� ����� ���� ������ 0";
		return 11;
	}
	last_id_1 ++;
	int a[last_id_1];
	input_mass(a, last_id_1);
	cout<<"������� ���������� ��������� �� ������ ������� - ";
	cin>>last_id_2;
	if (last_id_2 < 0)
	{
		cout<<"���������� ��������� �� ������ ������� �� ����� ���� ������ 0";
		return 12;
	}
	last_id_2 ++;
	int b[last_id_2];
	input_mass(b, last_id_2);
	cout<<"������ ������ �� "<<last_id_1<<" ����� ����� � ��������� �� 15 �� 15:"<<endl;
	output_mass(a, last_id_1);
	cout<<endl<<"������ ������ �� "<<last_id_2<<" ����� ����� � ��������� �� 15 �� 15:"<<endl;
	output_mass(b, last_id_2);
	max_1 = max_f(a, last_id_1);
	max_2 = max_f(b, last_id_2);
	cout<<endl<<"������������ ������� ������� ������� - "<<max_1<<endl;
	cout<<"������������ ������� ������� ������� - "<<max_2<<endl;
	if (max_1 < max_2) cout<<"������������ ������� �������� ������� ������, ��� ������������ ������� ������� �������.";
	if (max_1 > max_2) cout<<"������������ ������� ������� ������� ������, ��� ������������ ������� ������� �������.";
	if (max_1 == max_2) cout<<"������������ �������� �������� � ������� �������� �����.";
	return 0;
}
