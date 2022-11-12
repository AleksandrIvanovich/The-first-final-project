Console.Write("Введите количество строк, которые хотите ввести: ");
    int n = Convert.ToInt32(Console.ReadLine()); 
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