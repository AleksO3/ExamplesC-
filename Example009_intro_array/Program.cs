// Задача по нахождению максимального числа

Console.Clear();                                // Задаем очистку терминала при запуске программы
int Max(int arg1, int arg2, int arg3)           // задаем функцию типа Integer, с названием Max и имеющая аргументы 3 штуки
{
    int result_Max = arg1;                      // присваивается arg1
    if (arg2 > result_Max) result_Max = arg2;   // Если число2 больше, то result_Max присваиваем числу 2 и т.д.
    if (arg3 > result_Max) result_Max = arg3;   // и т.д.
    return result_Max;                          // выводные данные, что функция отдает
}

int[] array = { 1, 54, 5, 6, 8, 654, 44, 66, 73 };               // задан массив [] именем numders со значениями в {...}
//array[0] = 37;                                                          // обращаемся к массиву и нулевому индексу массива array присваиваем значение 37
//Console.WriteLine(array[0]);                                            // обращаемся к массиву выводим на экран значение 0-го индекса

int result = Max(
    Max (array[0], array[1], array [2]),
    Max (array[3], array[4], array [5]),
    Max (array[6], array[7], array [8])
);                                                                    // кладем в переменную result, значение, которое возвращает функция
Console.WriteLine(result);