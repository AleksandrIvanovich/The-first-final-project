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
        Console.WriteLine("Вы ввели некорректное число! Попробуйте снова.");          
        Console.WriteLine();     
  }      
    return result; 
}
int n = GetNumber("Введите число, обозначающее сколько строк вы хотите ввести: "); 
    string[] array = new string[n]; 
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите строку №{0}:\r\n  ", i + 1);
        array[i] = (Console.ReadLine()?? " ");
    }
    Console.WriteLine("Вы ввели следующие строки:");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.Write("Нажмите [Enter] для выхода...");
    Console.ReadLine();

int GetLengthSecondArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if(array[i].Length <= 3)
      {  
        count++;
      }
    }
  return count;
}
int size = GetLengthSecondArray(array);    
string[] newArray = new string[size];
void GetNewArray(string[] array, string[] newArray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[j] = array[i];
        j++;
        }
    }
    if (j == 0)
    Console.Write("таких строк нет!"); 
}

void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]}  ");
    }
    Console.WriteLine(); 
}

Console.Write("Строки с тремя и меньше символами: ");
GetNewArray(array, newArray);
PrintArray(newArray);