#include <iostream>
#include <windows.h>
#include <iomanip>
#include <string>

using namespace std;

struct a
{
	string name;
	int data, quantity, n, m;
	double price_a, price_b, price_all_a, price_all_b;
};

int main(int argc, char** argv)
{
	SetConsoleCP (1251);
	SetConsoleOutputCP (1251);
	system("mode con cols=200 lines=100");
	int id, last_id, n, m;
	cout<<"Enter the minimum storage time in the number of monthes - ";
	cin>>n;
	cout<<"Enter the maximum storage time in the number of monthes - ";
	cin>>m;
	if (n > m)
	{
		cout<<"The minimum shelf life of goods cannot exceed the maximum.";
		return 11;
	}
	cout<<"How many items need to be entered - ";
	cin>>last_id;
	if (last_id <= 0)
	{
		cout<<"You cannot enter less than 1 item.";
		return 12;
	}
	last_id ++;
	a stuff [last_id];
	last_id --;
	for (id = 1 ; id <= last_id ; id ++)
	{
		cout<<"Enter the name of "<<id<<" item - ";
		cin>>stuff[id].name;
		cout<<"Enter the price of "<<id<<" item - ";
		cin>>stuff[id].price_b;
		if (stuff[id].price_b < 0)
		{
			cout<<"The price doesn’t wash away from the negative.";
			return 21;
		}
		cout<<"Enter quantity of "<<id<<" item - ";
		cin>>stuff[id].quantity;
		if (stuff[id].quantity < 0)
		{
			cout<<"The qoantity doesn’t wash away from the negative.";
			return 22;
		}
		cout<<"Enter the storage time "<<id<<" item in the number of monthes - ";
		cin>>stuff[id].data;
	}
	for (id = 1 ; id <= last_id ; id ++)
	{
		if (stuff[id].data < n) stuff[id].price_a =  stuff[id].price_b;
		if (stuff[id].data >= n) stuff[id].price_a =  stuff[id].price_b / 1.5;
		if (stuff[id].data >= m) stuff[id].price_a =  stuff[id].price_b / 2.0;
		stuff[id].price_all_b = stuff[id].price_b * stuff[id].quantity;
		stuff[id].price_all_a = stuff[id].price_a * stuff[id].quantity;
	}
	cout<<"Storage of goods of the warehouse:"<<endl;
	cout<<"id"<<setw(20)<<"Name"<<setw(20)<<"Storage time"<<setw(20)<<"quantity"<<setw(30)<<"Price before markdown"<<setw(30)<<"Price after markdown"<<setw(30)<<"Total price before markdown"<<setw(30)<<"Total price after markdown"<<endl;
	for (id = 1 ; id <= last_id ; id += 1)
	{
		cout<<id<<setw(20);
		cout<<stuff[id].name<<setw(20);
		cout<<stuff[id].data<<setw(20);
		cout<<stuff[id].quantity<<setw(30);
		cout<<stuff[id].price_b<<setw(30);
		cout<<stuff[id].price_a<<setw(30);
		cout<<stuff[id].price_all_b<<setw(30);
		cout<<stuff[id].price_all_a<<endl;
	}
	cout<<"Minimum storage time is -  "<<n<<endl;
	cout<<"Maximum storage time is -  "<<m;
	err:
	return 0;
}
