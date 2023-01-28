void writeLen3(string[] arr){
    for(int i = 0; arr.Length>i; i++)
        if (arr[i].Length <=3)
            Console.WriteLine(arr[i]);
}


Console.Write("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] texts = new string[n];
for(int i = 0; texts.Length>i; i++){
    Console.Write($"Введите {i+1} элемент текст: ");
    texts[i] = Console.ReadLine();
}

writeLen3(texts);