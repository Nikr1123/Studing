#include <iostream>
#include <windows.h>
#include <math.h>

using namespace std;

int F (int X)
{
	if ((X / 10) % 10 != 0)
	{
		if (X % ((X / 10) % 10) == 0)	return X;
	}
	else 	return 0;
};

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int N, i = 0;
	cout<<"������� �������� N - ";
	cin>>N;
	if (N < 10)
	{
		cout<<"�������� N ������ ���� ������ 10.";
		return 11;
	}
	cout<<"����������� �����, �� ������������� "<<N<<" ��������� �� ���� 2 ������ �����: ";
	for (int n = 10 ; n <= N ; n ++)
	{
		if (F(n) != 0) cout<<F(n)<<" ";
		else i++;
	}
	if (i == N) cout<<"�����������.";
	return 0;
}
