#include <iostream>
#include <fstream>
#include <windows.h>
#include <iomanip>

using namespace std;

int main(int argc, char** argv)
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	ifstream file_in("8.txt");
	if (file_in.is_open())
	{
		ofstream file_out("8-1.txt");
		if (file_out.is_open())
		{
			string x;
			string kom = "//���������� ������������ ����";
			while (!file_in.eof())
			{
				getline(file_in, x);
				if (!file_in.eof())
				{
					file_out<<x<<endl;
					unsigned int b = -1;
					unsigned int a = x.find("using namespace std;");
					if (a != b)
					{
						file_out<<kom<<endl;
					}
				}
			}
			cout<<"����� ������ using namespace std ���������� ������ ����������� //���������� ������������ ����";
		}
		else cout<<"����������� ������� ����."<<endl;
		file_out.close();
	}
	else cout<<"����������� ������� ����."<<endl;
	file_in.close();
	return 0;
}
