#include <iostream>
#include <windows.h>
#include <string.h>

using namespace std;

int quantity (string s)
  {
     int q = 0;
     for (int i = 0 ; i < s.length() ; i ++)
     {
    	 if ((s[i] == '�') && (s[i + 1] == '�')) q++;
	 }
     return q;
  }

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	string s1, s2;
	cout<<"������� ������ ����������� - ";
	getline(cin, s1);
	cout<<"������� ������ ����������� - ";
	getline(cin, s2);
	cout<<"���������� '��' � ������ ����������� - "<<quantity (s1)<<endl;
	cout<<"���������� '��' �� ������ ����������� - "<<quantity (s2)<<endl;
	return 0;
}
