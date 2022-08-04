
string[] CreateArray(int count)
{
   
    string[] newArray = {"hgdsjh", "21f", "fdbf", "2df5r", "gfh"};
    // for(int i = 0; i < array.Length; i++)
    // {
    //     Console.Write($"Input {i + 1} element: ");
    //     newArray[i] = Console.ReadLine();
    // }
    Console.WriteLine();
    return newArray;
}
void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


Console.Write("Input size of array: ");
int count = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(count);
ShowArray(array);



string[] Three (string[] array)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length >= 3)
            Console.WriteLine(array[i] + " ");
    return array;
}
string[] array2 = Three(array);
ShowArray(array2);
// string str = "Hello";
// string[] strs = {};
// string k = Console.ReadLine();
// int z = Convert.ToInt32(k);
// for (int i = 0; i < z; i++ )
// {
//     string[] p = {str};
//     strs = p;
// }



// void ThreeCharacters (string[] args)
//     {
//       // Сортировка массива строк методом вставки
//       // 1. Объявление переменных
//       string[] arrayS; // массив строк
//       int count; // количество элементов в массиве
//       string stroka; // дополнительная переменная-строка

//       // 2. Ввести количество строк
//       Console.Write("Input count elementov: ");
//       count = Int32.Parse(Console.ReadLine());

//       // 3. Выделить память для массива из count строк
//       arrayS = new string[count];

//       // 4. Ввести данные массива с клавиатуры
//       Console.WriteLine("Enter array:");

//       for (int i = 0; i < arrayS.Length; i++)
//       {
//         Console.Write("AS[{0}] = ", i);
//         arrayS[i] = Console.ReadLine();
//       }

//     //   // 5. Сортировка методом вставки
//     //   for (int i = 0; i < AS.Length - 1; i++)
//     //     for (int j = i; j >= 0; j--)
//     //       if (String.Compare(AS[j], AS[j + 1]) > 0) // функция Compare()
//     //       {
//     //         // поменять значения местами
//     //         s = AS[j];
//     //         AS[j] = AS[j + 1];
//     //         AS[j + 1] = s;
//     //       }

//       // 6. Вывести массив AS
//       Console.WriteLine("Sorted array:");
//       for (int i = 0; i < arrayS.Length; i++)
//         Console.WriteLine("AS[{0}] = {1}", i, arrayS[i]);
//     }




