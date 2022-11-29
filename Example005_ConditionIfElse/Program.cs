Console.Write("Введите имя пользователя "); // Выводим на экран - введите имя пользователя
string username = Console.ReadLine(); // string - строчный тип переменных, а именно создаем место (контейнер), где будут храниться вводные значения от Console.Read.Line()
if(username.ToLower() == "aleks") // Ставим условие и если выполняется ToLower() позволяет вводить любой регистр, заглавные буквы или строчные
{    
    Console.WriteLine("Ho do you do, Aleks!"); // Тогда выводим это значение на экран
}
else
{
    Console.WriteLine("Hello, "); // Иначе выводим этот текст
    Console.WriteLine(username);
}