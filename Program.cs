// Задача: Написать программу, которая из сформированного массива строк содержащих символы и числа создать массив из строк,

// в который попадут только символы, не являющиеця цифрами.



// Входные данные можно получить путём ввода с клавиатуры,

// но лучше сделать автогенерацию данных. При решении не использовать "читерство".



// **список задач**



// 1 сформированного массива строк содержащих символы и числа

// 2 показать в консоле массив

// 3 создать массив из строк

// 4 перебрать данный массив и сохранить в массиве из строк только символы, не являющиеця цифрами. блок -схема

char[] symbols = new char[10];

string alf = "абвгджзиклмнопрстуфхцчшщэюя";

for (int i = 0; i < symbols.Length; i++)
{

int el = new Random().Next(1, 27);

string el2;

if (i % 2 == 0)

{

el2 = Convert.ToString(alf[el]);

symbols[i] = Convert.ToChar(el2);

Console.Write(symbols[i] + ",");

}
  else

{

el = el % 10;

el2 = Convert.ToString(el);

symbols[i] = Convert.ToChar(el2);

Console.Write(symbols[i] + ",");

}
}



Console.WriteLine();

int count = 0;

for (int i = 0; i < symbols.Length; i++)

{

bool flag = symbols[i] >= '0' && symbols[i] <= '9';

if (flag == false)

{

count++;

}



}

System.Console.WriteLine();

string[] finalString = new string[count];

int j = 0;

for (int i = 0; i < symbols.Length; i++)

{



bool flag = symbols[i] >= '0' && symbols[i] <= '9';

if (flag == false)

{



finalString[j] = Convert.ToString(symbols[i]);

Console.Write(finalString[j] + ",");

j++;

}





}

