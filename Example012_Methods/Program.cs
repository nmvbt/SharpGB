// string Method4 (int count, string text)
// {
//     //int i = 0;
//     string result = string.Empty;
//     for( int i = 0; i< count; i++)
//     //while(i < count)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(5, "g");
// Console.WriteLine(res);



// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



//=======Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с"

// string text = "— Я думаю, — Сказал князь, улыбаясь, — что,"
// +"ежели бы ваС послали вмеСто нашего милого Винценгероде,"
// +"вы бы взяли приступом Согласие пруССкого короля."
// +"Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '_');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
//-----------------------------------------------------------------------
// Упорядочивание массива

// int[] arr = {1, 5, 4, 3, 2 ,6 ,7 ,1 ,1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j]< array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// Console.WriteLine();
// PrintArray(arr);

// В обратную сторону

// int[] arr = {1, 5, 4, 3, 2 ,6 ,7 ,1 ,1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[maxPosition]) maxPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// Console.WriteLine();
// PrintArray(arr);