int GetNumber(string message)
{
int result = 0;
bool correctInput = false;
while(!correctInput)
  {         
    Console.WriteLine(message);         
      correctInput = int.TryParse(Console.ReadLine(), out result); 

    if(result < 1)             
      correctInput = false;  

    if(!correctInput)             
        Console.WriteLine("Вы ввели некорректное число");          
        Console.WriteLine();     
  }      
    return result; 
}
int n = GetNumber("Введите количество строк, которые хотите ввести: "); 
    string[] array = new string[n]; 
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("Вы ввели следующие строки:");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.Write("Нажмите [Enter] для выхода...");
    Console.ReadLine();

string[] newArray = new string[array.Length];
void GetNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[count] = array[i];
        count++;
        }
    }
    if (count == 0)
    Console.Write("таких строк нет!"); 
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(); 
}

Console.Write("Строки с тремя и меньше символами: ");
GetNewArray(array, newArray);
PrintArray(newArray);