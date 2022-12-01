Console.Clear();

void FillArray(int[] collection)                        // задали  типа void(не возвращающий значения) с наименованием FillArray, 
{                                                       //аргументом является collection
    int length = collection.Length;                     // получить длину массива
    int index = 0;                                      // Установили счетчик с 0-го элемента массива
    while (index < length)                              // выполнять действие пока счетчик < длины массива
    {
        collection[index] = new Random().Next(1, 10);   // Обращаемся к аргуенту collection[index] на позицию index и положить туда новое целое число с диапазоном 1-10 
        index++;                                        // с каждым шагом index увеличить на 1

    }
}

void PrintArray(int[] col)                              // задали  типа void(не возвращающий значения) с наименованием PrintArray,
{                                                       //аргументом является col
    int count = col.Length;                             // счетчик ставится по длине массива
    int position = 0;                                   // с нулевого номера элемента
    while (position < count)                            // выполнять действие пока позиция < длины массива
    {
        Console.WriteLine(col[position]);               // выводим на экран значение текущего элемента
        position++;                                     // увеличение значения текущей позиции
    }
}

int[] array = new int[10]; // new int[10] - создай массив, в котором будет 10 элементов. Для заполнения массива разными элементами
// используем метод, описанный выше (строчка.3)

FillArray(array);                                       // TESTING Вызываем метод с аргументом нашего массива, используя FillArray
PrintArray(array);                                      // TESTING Распечатывает наш массив, используя PrintArray