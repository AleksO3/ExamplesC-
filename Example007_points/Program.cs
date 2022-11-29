﻿/* Суть задачи! Определить 3 точки. Выбрать 2 любых. Найти середину отрезка между ними и поставить точку. Выбрать случайную вершину треугольника. Соединить с полученной "серединной" точкой.
Все это будет происходить до указанного числа "счетчика" в треугольнике на данный момент*/
Console.Clear();                    // Очищает терминал перед выводом
//Console.SetCursorPosition(1,1);  // Рисуем "точку" с координатами т.А (отступ по X равен 1 и отступ(TOP) по y равен 1)
//Console.WriteLine("+");           // Выводим на экран + с вышеуказанными координатами

int xa = 25, ya = 1,                 // Задаем целочисленные значения координат через запятую для удобства. В конце не забываем ; и делать терминал поБОЛЬШЕ
    xb = 1, yb = 10,
    xc = 50, yc = 10;

Console.SetCursorPosition(xa,ya);   // Рисуем "точку" с координатами
Console.WriteLine("*");             // Выводим на экран + с вышеуказанными координатами

Console.SetCursorPosition(xb,yb);   // Рисуем "точку" с координатами
Console.WriteLine("*");             // Выводим на экран + с вышеуказанными координатами

Console.SetCursorPosition(xc,yc);   // Рисуем "точку" с координатами
Console.WriteLine("*");             // Выводим на экран + с вышеуказанными координатами

int x = xa, y = xb;                 // Задаем (определяем какие-то 2 точки, обозначая координатами)
int count = 0;                      // Определяем счетчик с 0

while (count < 10000)                  // Задаем действие программы циклом до 10 (в этот раз) или больше или меньше
{
    int what = new Random().Next(0,3); // Генератор псевдослучайных чисел от 0 до 3, где 0,1,2 включительно, а 3 нет
    if (what == 0)                     // И если переменная what не равна нулю, то выполняем следующие действия
    {
        x = (x + xa)/2;                // а именно присваиваем координатам точки длину отрезка/2
        y = (y + ya)/2;
    }
    if (what == 1)
    {
        x = (x + xb)/2;                // а именно присваиваем координатам точки длину отрезка/2
        y = (y + yb)/2;
    }
    if (what == 2)
    {
        x = (x + xc)/2;                // а именно присваиваем координатам точки длину отрезка/2
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count = count + 1;                    // без увеличения счетчика на 1 каждый раз, будет бесконечный цикл
}
