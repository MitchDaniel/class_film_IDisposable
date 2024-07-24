using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_modul_11
{
    internal class Film : IDisposable
    {
        public string Name { get; set; } = string.Empty;

        public string Studio { get; set; } = string.Empty;

        public string Ganre { get; set; } = string.Empty;

        public TimeOnly Duration { get; set; }

        public int Year { get; set; }

        public Film(string name, string studio, string ganre, TimeOnly duration, int year)
        {
            Name = name;
            Studio = studio;
            Ganre = ganre;
            Duration = duration;
            Year = year;
        }

        ~Film()
        {
            Dispose(false);
            Console.WriteLine("Destructor");
            // какое задание, такой и деструктор
        }

        private bool disposed = false;

        public void Dispose()
        {
            Console.WriteLine($"Rip film {Name}");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine("Освобождаю ресурсы. Отстыковка");
            }
            disposed = true;
        }
    }
}

//Создайте класс Фильм. Класс должен хранить такую информацию:
//-Название фильма
//-Название киностудии
//-Жанр
//-Длительность
//-Год выпуска
//Реализуйте в классе методы и свойства, необходимые для функционирования класса.
//Добавьте в классе деструктор. Напишите код для тестирования функциональности класса.
//Напишите код для вызова деструктора.