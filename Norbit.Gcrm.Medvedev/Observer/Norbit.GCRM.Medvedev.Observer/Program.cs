using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.GCRM.Medvedev.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var scChanel = new ScientificChannel();
            var gameChanel = new GameChannel();

            var scientist = new Scientist("Ученый Илья");

            var gamer = new Gamer("Игрок Данил");

            var student = new Student("Студент Елена");

            scChanel.Subscribe(scientist);
            scChanel.Subscribe(student);

            gameChanel.Subscribe(gamer);
            gameChanel.Subscribe(student);

            scChanel.PublisVideo("Линейная математика", 200);
            scChanel.PublisVideo("Ядерная физика", 13);
            scChanel.PublisVideo("математика для начальных классов", 4);

            gameChanel.PublisVideo("Skyrim", 200);
            gameChanel.PublisVideo("Oblivion", 13);
            gameChanel.PublisVideo("Skyrim: Эпилог", 4);

        }
    }
}
