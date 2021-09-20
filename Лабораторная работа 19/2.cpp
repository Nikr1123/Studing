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
	cout<<"Сколько карточек нужно ввести - ";
	cin>>last_id;
	if (last_id < 1)
	{
		cout<<"Нельзя ввести менее 1 карточки.";
		return 11;
	}
	last_id ++;
	a book[last_id];
	last_id --;
	for (id = 1 ; id <= last_id; id ++)
	{
		cout<<"Введите фамилию заказчика "<<id<<"-ной книги - ";
		cin>>book[id].fam;
		cout<<"Введите дату выдачи "<<id<<"-ой книги в формате ДД ММ ГГГГ - ";
		cin>>book[id].day_go>>book[id].month_go>>book[id].year_go;
		if ((book[id].day_go < 1) || (book[id].day_go > 32))
		{
			cout<<"Неверно введён день выдачи книги.";
			return 21;
		}
		if ((book[id].month_go < 1) || (book[id].month_go > 12))
		{
			cout<<"Неверно введён месяц выдачи книги.";
			return 22;
		}
		if ((book[id].year_go < 1921) || (book[id].year_go > 2021))
		{
			cout<<"Неверно введён год выдачи книги.";
			return 23;
		}
		cout<<"Введите дату возврата "<<id<<"-ой книги в формате ДД ММ ГГГГ - ";
		cin>>book[id].day_come>>book[id].month_come>>book[id].year_come;
		if ((book[id].day_come < 1) || (book[id].day_come > 32))
		{
			cout<<"Неверно введён день возврата книги.";
			return 31;
		}
		if ((book[id].month_come < 1) || (book[id].month_come > 12))
		{
			cout<<"Неверно введён месяц возврата книги.";
			return 32;
		}
		if ((book[id].year_come < 1921) || (book[id].year_come > 2021))
		{
			cout<<"Неверно введён год возврата книги.";
			return 33;
		}
		if (book[id].year_come < book[id].year_go)
		{
			cout<<"Книга не может быть возвращена раньше, чем была заказана";
			return 41;
		}
		else
		{
			if ((book[id].year_come <= book[id].year_go) && (book[id].month_come < book[id].month_go))
			{
				cout<<"Книга не может быть возвращена раньше, чем была заказана";
				return 42;
			}
			else
			{
				if ((book[id].year_come <= book[id].year_go) && (book[id].month_come <= book[id].month_go) && (book[id].day_come < book[id].day_go))
				{
					cout<<"Книга не может быть возвращена раньше, чем была заказана";
					return 43;
				}
			}
		}
	}
	cout<<"Журнал приёма/выдачи книг:"<<endl;
	cout<<"№"<<setw(16)<<"Фамилия"<<setw(16)<<"Дата выдачи"<<setw(16)<<"Дата возврата"<<endl;
	for (id = 1 ; id <= last_id; id ++)
	{
		cout<<id<<setw(16);
		cout<<book[id].fam<<setw(8);
		cout<<book[id].day_go<<"."<<book[id].month_go<<"."<<book[id].year_go<<setw(12);
		cout<<book[id].day_come<<"."<<book[id].month_come<<"."<<book[id].year_come<<endl;
		if ((book[id].day_go == 25) && (book[id].month_go == 04) && (book[id].year_go == 2013)) check ++;
	}
	cout<<"Количество человек, заказавших книгу 25.04.13: "<<check;
	return 0;
}
