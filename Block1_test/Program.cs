// программа из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив вводится с клавиатуры, 
// При решении не используются коллекциями, только массивы.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void ConsoleInput(string[] array) // метод ввода строк с консоли в массив
{
// переключение кодировки консоли в UTF-16 обеспечивает ввод с клавиатуры расширенного набора символов, вкл. кириллицу
    Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
//
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        System.Console.Write($"Введите элемент {i + 1}: ");
        array[i] = Console.ReadLine()!;
    }
}

string[] LessFourSymbols(string[] array) // метод создает новый массив из элементов входного массива
{
    int k = array.Length; // размер входного массива
    string[] newArray = new string[0]; //создает новый массив нулевой длины
    int N = 0; // начальный размер нового массива = 0
    for (int i = 0; i < k; i++)
    {
        if (array[i].Length <= 3) //число символов элемента массива(строки)<=3?
        {
            Array.Resize(ref newArray, N + 1); // увеличивает размер нового массива на 1
            newArray[N] = array[i]; // записывает в новый масиив значение элемента входного массива
            N++;
        }
    }
    return newArray; // возвращает новый массив
}

System.Console.Write("Укажите число элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
string[] my_array = new string[size];
ConsoleInput(my_array);
System.Console.WriteLine($"Начальный массив: [{string.Join(", ", my_array)}]");
System.Console.WriteLine($"Новый массив: [{string.Join(", ", LessFourSymbols(my_array))}]");