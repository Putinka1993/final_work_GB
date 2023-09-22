

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Укажите длину массива: ");
int len_AR = int.Parse(Console.ReadLine());

string[] result = CreateArr(len_AR);

string[] CreateArr(int l_ar){
    string[] res = new string[l_ar];
    for (int i = 0; i < l_ar; i++){
        Console.WriteLine($"Введите {i+1}-ое строковое значение: ");
        res[i] = Console.ReadLine();
    }
    return res; 
}

string[] SortArray(string[] arr){
    
}





Console.WriteLine($"Заданный массив [{String.Join(", ", result)}]");





