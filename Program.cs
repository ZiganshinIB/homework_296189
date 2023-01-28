Console.Write("Введите колличество элементов");
int n = Convert.ToInt32(Console.ReadLine());

string[] texts = new string[n];

for(int i = 0; texts.Length>i; i++){
    Console.Write($"Введите {i+1} элемент текст: ");
    texts[i] = Console.ReadLine();
}
