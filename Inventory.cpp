#include <iostream>
#include <string>
#include <cstdlib>
using namespace std;

int main()
{
    system("chcp 1251>nul");
 const int MAX_ITEMS = 10;
 string inventory[MAX_ITEMS];
 int numltems = 0;
 inventory[numltems++] ="���";
 inventory[numltems++] ="�������";
 inventory[numltems++] ="���";
 cout << "���� ����:\n";
 for (int i =0; i < numltems; ++i)
 {
     cout << inventory[i] << endl;
 }
  cout << "\n�� ������� ��� �� ������ �����. ";
  inventory[0] = "������ �����";
  cout << "\n���� ����:\n";
  for (int i =0; i < numltems; ++i)
  {
      cout << inventory[i] << endl;
  }
  cout << "\n�������� �������� '" << inventory[0] << "' ����� ";
  cout << inventory[0] .size() << " ����. \n";
  cout << "\n�� ����� ���������� �����.";
  if (numltems < MAX_ITEMS)
  {
      inventory[numltems++] ="���������� �����";
  }
  else
  {
      cout << "� ��� ���������� ������, �� �� ������� ������.";
  }
  cout << "\n���� ����:\n";
  for (int i =0; i < numltems; ++i)
  {
      cout <<inventory[i] << endl;
  }
  return 0;
}
