// нахождение нужного элемента массива и указания его индекса, с использованием метода
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


int IndexOf(int[] collection, int find)                 // метод, возвращающий позицию, в качестве аргумента приходит массив collection и аргумент find
{
    int count = collection.Length;                      // определяем кол-во элементов
    int index = 0;                                      // для счелкания массива
    int position = -1;                                  // новая переменная для сохранения позиции стр.35. (-1 для то чтобы если элемента нет, показал "-1")
    while (index < count)
    {
        if (collection[index] == find)                  // Если индекс collection совпал с find, то нужно будет сохранить позицию, стр.33 
        {
            position = index;                           // кладем значение индекса в позишн   
            break;
        }
        index++;
    }
    return position;                                    // Ожидаем позицию нашего элемента
}

int[] array = new int[10]; 
// new int[10] - создай массив, в котором будет 10 элементов. Для заполнения массива разными элементами, используем методы, описанные выше (строчка.4 и 16)
FillArray(array);                                        // TESTING Вызываем метод с аргументом нашего массива, используя FillArray
/*array[4]=4;                                            // принудительно добавим пару позиций с 4-ми, к примеру, на 4-ю и 6-ю, если не будет сгенерированных!
array[6]=4;
*/
PrintArray(array);                                       // TESTING Распечатывает наш массив, используя PrintArray
Console.WriteLine();                                     // Пустая строка для удобства

int pos = IndexOf(array, 7);                             // определили переменную pos и дали ей результат работы метода IndexOf, в аргументах которого наш массив и, к примеру 7
Console.WriteLine(pos);                                  // выводим pos