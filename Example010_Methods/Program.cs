// Имеется одномерный массив array из n эллементов, требуется найти элемент массива, раваный find
Console.Clear();
int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 }; // указываем массив [] array

int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;                          // Прервать дальнейшее выполнение, на случай 2-х и более одинаковых элементов массива
    }
    index++;
    //index = index + 1;
}

