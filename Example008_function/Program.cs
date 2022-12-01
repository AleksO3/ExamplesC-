// задача найти максимальное из 9 чисел
Console.Clear();                        // Задаем очистку терминала при запуске программы
int Max(int arg1, int arg2, int arg3)   // Возвращаемый тип данных - метод, имя метода, ([Тип данных, имя аргумента,...])
{                                       // start Тело метода
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;                      // Значение, соответствующее возвращаемому типу данных, что функция отдает
}                                       // start Тело метода



int a1 = 15;                            // задали переменные...
int b1 = 2155;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 548;
int c3 = 33;

/*int max = a1;// если без использования функции с помощью оператора IF
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;
*/
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);