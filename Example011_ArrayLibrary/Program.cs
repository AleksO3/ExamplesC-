Console.Clear();

void FillArray(int[] collection);                       // задали  типа void(не возвращающий значения) с названием collection
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }
}




int[] array = new int[10]; // new int[10] - создай массив, в котором будет 10 элементов. Для заполнения массива разными элементами
// используем метод, описанный выше (стр.3)
