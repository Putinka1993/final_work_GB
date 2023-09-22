

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Укажите длину массива: ");
int len_AR = int.Parse(Console.ReadLine());

string[] input = CreateArr(len_AR);

string[] CreateArr(int l_ar){
    string[] res = new string[l_ar];
    for (int i = 0; i < l_ar; i++){
        Console.WriteLine($"Введите {i+1}-ое строковое значение: ");
        res[i] = Console.ReadLine();
    }
    return res; 
}

string[] result = CreateSortArray(input);

string[] CreateSortArray(string[] arr){
    // подсчет символов в строке для создания массива (т.к. в условиях задачи просят создать массив) 
    int count = 0;
    foreach(string el in arr){
        if (el.Length <= 3) {
        count++;
        }
    }
    // Создание нового с кол-вом слов меньше или равно длины 3 
    string[] result = new string[count]; 
    
    foreach(string el in arr){
        int i = 0;
        if (el.Length <= 3) {
            result[i] = el;
            i++;
        }
    }
    return result;
}



    

// Вывод вводимого массива
Console.WriteLine($"Заданный массив: [{String.Join(", ", input)}]");

// Вывод результата по условию задачи
Console.WriteLine($"Результат сортировки массива по условиям задачи: [{String.Join(", ", result)}]");




