#include <iostream>
#include <fstream>
#include <windows.h>
#include <iomanip>

using namespace std;


int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	cout<<"В файле записаны числа:"<<endl;
	ifstream file ("f.txt");
	int positiv = 0, negativ = 0;
	while (!file.eof ())
	{
		if (!file.eof ())
		{
			int x;
			file>>x;
			cout<<x<<setw(3);
			if (x > 0) positiv ++;
			if (x < 0) negativ ++;
		}
	}
	cout<<endl<<"Количество положительных чисел - "<<positiv<<endl;
	cout<<"Количество отрицательных чисел - "<<negativ<<endl;
	if (positiv > negativ) cout<<"В файле больше положительных чисел, чем отрицательных.";
	if (positiv < negativ) cout<<"В файле больше отрицательных чисел, чем положительных.";
	if (positiv == negativ) cout<<"отрицательных и положительных чисел в файле поровну.";
	return 0;
}

