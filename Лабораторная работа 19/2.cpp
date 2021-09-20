#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

struct a
{
	string fam;
	int day_go, month_go, year_go, day_come, month_come, year_come; 
};

int main (int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int id, last_id, check = 0;
	cout<<"������� �������� ����� ������ - ";
	cin>>last_id;
	if (last_id < 1)
	{
		cout<<"������ ������ ����� 1 ��������.";
		return 11;
	}
	last_id ++;
	a book[last_id];
	last_id --;
	for (id = 1 ; id <= last_id; id ++)
	{
		cout<<"������� ������� ��������� "<<id<<"-��� ����� - ";
		cin>>book[id].fam;
		cout<<"������� ���� ������ "<<id<<"-�� ����� � ������� �� �� ���� - ";
		cin>>book[id].day_go>>book[id].month_go>>book[id].year_go;
		if ((book[id].day_go < 1) || (book[id].day_go > 32))
		{
			cout<<"������� ����� ���� ������ �����.";
			return 21;
		}
		if ((book[id].month_go < 1) || (book[id].month_go > 12))
		{
			cout<<"������� ����� ����� ������ �����.";
			return 22;
		}
		if ((book[id].year_go < 1921) || (book[id].year_go > 2021))
		{
			cout<<"������� ����� ��� ������ �����.";
			return 23;
		}
		cout<<"������� ���� �������� "<<id<<"-�� ����� � ������� �� �� ���� - ";
		cin>>book[id].day_come>>book[id].month_come>>book[id].year_come;
		if ((book[id].day_come < 1) || (book[id].day_come > 32))
		{
			cout<<"������� ����� ���� �������� �����.";
			return 31;
		}
		if ((book[id].month_come < 1) || (book[id].month_come > 12))
		{
			cout<<"������� ����� ����� �������� �����.";
			return 32;
		}
		if ((book[id].year_come < 1921) || (book[id].year_come > 2021))
		{
			cout<<"������� ����� ��� �������� �����.";
			return 33;
		}
		if (book[id].year_come < book[id].year_go)
		{
			cout<<"����� �� ����� ���� ���������� ������, ��� ���� ��������";
			return 41;
		}
		else
		{
			if ((book[id].year_come <= book[id].year_go) && (book[id].month_come < book[id].month_go))
			{
				cout<<"����� �� ����� ���� ���������� ������, ��� ���� ��������";
				return 42;
			}
			else
			{
				if ((book[id].year_come <= book[id].year_go) && (book[id].month_come <= book[id].month_go) && (book[id].day_come < book[id].day_go))
				{
					cout<<"����� �� ����� ���� ���������� ������, ��� ���� ��������";
					return 43;
				}
			}
		}
	}
	cout<<"������ �����/������ ����:"<<endl;
	cout<<"�"<<setw(16)<<"�������"<<setw(16)<<"���� ������"<<setw(16)<<"���� ��������"<<endl;
	for (id = 1 ; id <= last_id; id ++)
	{
		cout<<id<<setw(16);
		cout<<book[id].fam<<setw(8);
		cout<<book[id].day_go<<"."<<book[id].month_go<<"."<<book[id].year_go<<setw(12);
		cout<<book[id].day_come<<"."<<book[id].month_come<<"."<<book[id].year_come<<endl;
		if ((book[id].day_go == 25) && (book[id].month_go == 04) && (book[id].year_go == 2013)) check ++;
	}
	cout<<"���������� �������, ���������� ����� 25.04.13: "<<check;
	return 0;
}
