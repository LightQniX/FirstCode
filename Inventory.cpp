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
 inventory[numltems++] ="Меч";
 inventory[numltems++] ="Доспехи";
 inventory[numltems++] ="Щит";
 cout << "Ваши вещи:\n";
 for (int i =0; i < numltems; ++i)
 {
     cout << inventory[i] << endl;
 }
  cout << "nВы меняете меч на боевой топор.  ";
  inventory[0] = "Боевой топор";
  cout << "\nВаши вещи:\n";
  for (int i =0; i < numltems; ++i)
  {
      cout << inventory[i] << endl;
  }
  cout << "\nНазвание предмета '" << inventory[0] << "' имеет ";
  cout << inventory[0] .size() << " букв. \n";
  cout << "\nВы нашли исцеляющее зелье.";
  if (numltems < MAX_ITEMS)
  {
      inventory[numltems++] ="исцеляющее зелье";
  }
  else
  {
      cout << "У вас переполнен рюкзак, вы не унесете больше.";
  }
  cout << "\nВаши вещи:\n";
  for (int i =0; i < numltems; ++i)
  {
      cout <<inventory[i] << endl;
  }
  return 0;
