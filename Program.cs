namespace CSharp_Practice_modul_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(Film DeadpoolAndWolverine = new Film("Deadpool And Wolverine", "Marvel Studios", "Superhero", new TimeOnly(2, 6), 2024))
            {
                Console.WriteLine(DeadpoolAndWolverine.Name);
            }
           
            Console.Read();
        }
    }
}


//Создайте класс Фильм. Класс должен хранить такую информацию:
//-Название фильма
//- Название киностудии
//- Жанр
//- Длительность
//- Год выпуска
//Реализуйте в классе методы и свойства, необходимые для функционирования класса.
//Добавьте в классе деструктор. Напишите код для тестирования функциональности класса.
//Напишите код для вызова деструктора.