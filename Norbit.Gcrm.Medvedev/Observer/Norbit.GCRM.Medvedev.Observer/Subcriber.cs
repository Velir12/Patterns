using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.Observer
{
    /// <summary>
    /// Подписчик.
    /// </summary>
    public abstract class Subcriber
    {
        #region Свойства

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Cтатус.
        /// </summary>
        public string Status { get; set; }

        #endregion

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"> Имя.</param>
        public Subcriber(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Обновление реакции подписчика на выход нового видео.
        /// </summary>
        /// <param name="author"> Автор канала.</param>
        public abstract void Update(Author author);

        /// <summary>
        /// Приведение информации о подписчике к строке.
        /// </summary>
        /// <returns> Информация о подписчике.</returns>
        public override string ToString()
        {
            return $"{Name}: {Status}\n";
        }

    }

    #region Классы реализующие класс Subscriber

    /// <summary>
    /// Ученый.
    /// </summary>
    public class Scientist : Subcriber
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"> Имя ученого.</param>
        public Scientist(string name) : base(name)
        {
            Status = "Работает";
        }

        /// <summary>
        /// Обновление реакции подписчика на выход нового видео.
        /// </summary>
        /// <param name="author"> Автор канала.</param>
        public override void Update(Author author)
        {
            var reaction = "";
            var title = author.video.Title;
            if (title.Contains("математика"))
            {
                reaction = $"{Name}: Видео по теме {title} меня не интересует";
            }
            else
            {
                reaction = $"{Name}: С радостью посмотрю новое видео {title}!";
                Status = $"Смотрит видео {title}\n";
            }

            Console.WriteLine(reaction);
            Console.WriteLine(this);
        }
    }

    /// <summary>
    /// Студент.
    /// </summary>
    public class Student : Subcriber
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"> Имя студента.</param>
        public Student(string name) : base(name)
        {
            Status = "Учится";
        }

        /// <summary>
        /// Обновление реакции подписчика на выход нового видео.
        /// </summary>
        /// <param name="author"> Автор канала.</param>
        public override void Update(Author author)
        {
            var reaction = "";
            var scientistAutor = author as ScientificChannel;

            var title = author.video.Title;

            if (author.video.ViewingTime > 15)
            {
                reaction = $"{Name}: {title} слишком длинное для меня";
            }
            else
            {
                reaction = $"{Name}: Посмотрю новое видео {title}!";
                Status = $"Смотрит видео {title}\n";
            }

            Console.WriteLine(reaction);
            Console.WriteLine(this);
        }
    }

    /// <summary>
    /// Геймер.
    /// </summary>
    public class Gamer : Subcriber
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"> Имя геймера.</param>
        public Gamer(string name) : base(name)
        {
            Status = "Играет";
        }

        /// <summary>
        /// Обновление реакции подписчика на выход нового видео.
        /// </summary>
        /// <param name="author"> Автор канала.</param>
        public override void Update(Author author)
        {
            var reaction = "";
            if (author.video.Title.Contains("Skyrim"))
            {
                reaction = $"{Name}: Новое видео по интересующей меня игре!";
                Status = $"Смотрит видео {author.video.Title}\n";
            }
            else
            {
                reaction = $"{Name}: Эта игра меня не интересует!";
            }

            Console.WriteLine(reaction);
            Console.WriteLine(this);
        }

    }

    #endregion
}
