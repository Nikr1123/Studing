#include <iostream>
#include <windows.h>
#include <string.h>

using namespace std;

int quantity (string s)
  {
     int q = 0;
     for (int i = 0 ; i < s.length() ; i ++)
     {
    	 if ((s[i] == 'а') && (s[i + 1] == 'с')) q++;
	 }
     return q;
  }

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	string s1, s2;
	cout<<"Введите первое предложение - ";
	getline(cin, s1);
	cout<<"Введите второе предложение - ";
	getline(cin, s2);
	cout<<"Количество 'ас' в первом предложении - "<<quantity (s1)<<endl;
	cout<<"Количество 'ас' во втором предложении - "<<quantity (s2)<<endl;
	return 0;
}
