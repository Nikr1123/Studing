#include <iostream>
#include <iomanip>
#include <windows.h>

using namespace std;

struct a
{
	string fam, name, otch;
	double o_1, o_2, o_3, o_4, o_sr; 
};

int main (int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int id, last_id, i = 0;
	double all_sr = 0;
	cout<<"������� ��������� ����� ������ - ";
	cin>>last_id;
	if (last_id < 1)
	{
		cout<<"������ ������ ����� 1 ��������.";
	}
	else
	{
		last_id++;
		a student[last_id];
		last_id--;
		for (id = 1 ; id <= last_id; id ++)
		{
			cout<<"������� ������� "<<id<<"-���� �������� - ";
			cin>>student[id].otch;
			cout<<"������� ��� "<<id<<"-���� �������� - ";
			cin>>student[id].name;
			cout<<"������� �������� "<<id<<"-���� �������� - ";
			cin>>student[id].fam;
			cout<<"������� 4 ������ "<<id<<"-���� �������� (������: 2.5 5 4.3 3.5) - ";
			cin>>student[id].o_1>>student[id].o_2>>student[id].o_3>>student[id].o_4;
			student[id].o_sr = (student[id].o_1 + student[id].o_2 + student[id].o_3 + student[id].o_4) / 4.0;
			all_sr += student[id].o_sr;
		}
		all_sr /= last_id;
		cout<<"�"<<setw(16)<<"�������"<<setw(16)<<"���"<<setw(16)<<"��������"<<setw(16)<<"������"<<setw(16)<<"������� ����"<<endl;
		for (id = 1 ; id <= last_id; id ++)
		{
			cout<<id<<setw(16);
			cout<<student[id].fam<<setw(16);
			cout<<student[id].name<<setw(16);
			cout<<student[id].otch<<setw(5);
			cout<<student[id].o_1<<", "<<student[id].o_2<<", "<<student[id].o_3<<", "<<student[id].o_4<<setw(16);
			cout<<student[id].o_sr<<endl;
		}
		for (id = 1 ; id <= last_id; id ++)
		{
			if (student[id].o_sr > all_sr) i++;
		}
		if (i == 0) cout<<"��� ���������, ������� ���� ������� ��������� ������� ���� ������."<<endl;
		else
		{
			cout<<"������ ���������, ������� ���� ������� ��������� ������� ���� ������ ("<<all_sr<<"):"<<endl;
			cout<<"�"<<setw(16)<<"�������"<<setw(16)<<"���"<<setw(16)<<"��������"<<setw(16)<<"������� ����"<<endl;
			for (id = 1 ; id <= last_id; id ++)
			{
				if (student[id].o_sr > all_sr)
				{
					cout<<id<<setw(16);
					cout<<student[id].fam<<setw(16);
					cout<<student[id].name<<setw(16);
					cout<<student[id].otch<<setw(16);
					cout<<student[id].o_sr;
					cout<<endl;
				}
			}
		}
		i == 0;
		for (id = 1 ; id <= last_id; id ++)
		{
			if ((student[id].o_1 < 3.0) || (student[id].o_2 < 3.0) || (student[id].o_3 < 3.0) || (student[id].o_4 < 3.0)) i++;
		}
		if (i == 0) cout<<"� ������ ��� �����������."<<endl;
		else
		{
			cout<<"������ �����������:"<<endl;
			cout<<"�"<<setw(16)<<"�������"<<setw(16)<<"���"<<setw(16)<<"��������"<<endl;
			for (id = 1 ; id <= last_id; id ++)
			{
				if ((student[id].o_1 < 3.0) || (student[id].o_2 < 3.0) || (student[id].o_3 < 3.0) || (student[id].o_4 < 3.0))
				{
					cout<<id<<setw(16);
					cout<<student[id].fam<<setw(16);
					cout<<student[id].name<<setw(16);
					cout<<student[id].otch;
					cout<<endl;
				}
			}
		}
		for (id = 1 ; id <= last_id; id ++)
		{
			if ((student[id].o_1 == 5.0) && (student[id].o_2 == 5.0) && (student[id].o_3 == 5.0) && (student[id].o_4 == 5.0)) i++;
		}
		if (i == 0) cout<<"� ������ ��� ����������."<<endl;
		else
		{
			cout<<"������ ����������:"<<endl;
			cout<<"�"<<setw(16)<<"�������"<<setw(16)<<"���"<<setw(16)<<"��������"<<endl;
			for (id = 1 ; id <= last_id; id ++)
			{
				if ((student[id].o_1 == 5.0) && (student[id].o_2 == 5.0) && (student[id].o_3 == 5.0) && (student[id].o_4 == 5.0))
				{
					cout<<id<<setw(16);
					cout<<student[id].fam<<setw(16);
					cout<<student[id].name<<setw(16);
					cout<<student[id].otch;
					cout<<endl;
				}
			}
		}
	}
	return 0;
}
