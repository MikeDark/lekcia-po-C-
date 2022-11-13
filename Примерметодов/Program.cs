//Вид 1
void Method1()
{
    Console.WriteLine("Автор программы ...");
}
//Method1();

//Вид 2
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);

//Вид 3
int Method3 ()
{
    return DateTime.Now.Year;
}

//int year = Method3 ();
//Console.WriteLine(year);

//Вид 4
string Method4 (int count, string C)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + C;
        i++;
    }
    return result;
}

//string res = Method4 (10, "slf");
//Console.WriteLine(res);

//цикл for
string Method41 (int count, string C)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + C;
    }
    return result;
}

//string res = Method41 (10, "slf");
//Console.WriteLine(res);

//Цикл в цикле. Вывод таблицы умножения на экран
//for (int i = 2; i <= 10; i++)
//{
 //   for (int j = 2; j <=10; j++)
 //   {
   //     Console.WriteLine ($"{i} * {j} = {i * j}");
   // }
  //  Console.WriteLine();
//}

//Задача: 

string text = "- Я думаю, - сказал князь, улыбаясь, - что," 
             + "ежели бы вас послали вместо нашего милого Винценгероде ," 
             + "вы бы взяли приступом согласие прусского короля. " 
             + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] // r

string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text [i]}";
    }
    return result;
}

string newText = Replace( text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace( newText, 'к', 'К');
//Console.WriteLine(newText);
//newText = Replace( newText, 'С', 'с');


int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array) //Вывод массива на экран.
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array) //Сортировка массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
         for (int j = i+1; j < array.Length; j++)
         {
             if(array[j] < array[minPosition]) minPosition = j;
         }


        int temporary = array[i];
        array[i] = array[minPosition]; //простой обмен двух позиций местами
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
