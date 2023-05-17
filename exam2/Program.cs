// цикл for

//метод из предыдущего варианта, но с циклом for
/*
string Method4(int count, string c){
    string result = String.Empty; 
    for(int i = 0; i < count; i++){
        result = result + c;
    }
    return result;
}
string res = Method4(10, "Method4 ");
Console.WriteLine(res);
*/

//цтклы в цикле, делаем таблицу умножения 
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/

//алгоритм сортирования большего к меньшему через min max

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

//метод для вывода массива
void PrintArray(int[] arr){
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
//метод для сортировки
void SelectionSort(int[] arr){
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i; //переменная для хранения индекса минимального
        for (int j = i + 1; j < arr.Length; j++)//цикл для находждения минимального 
        {
            if(arr[j] < arr[minPosition]){
                minPosition = j;
            }
        }
        //меняем местами как обычно
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
