using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_10._05._2023
{

    internal class Program
    {
      
        static void Main(string[] args)
        {     
            List<Gamers> comand1 = new List<Gamers>();
            List<Gamers> comand2 = new List<Gamers>();
            //создали экземпляры класса
            Gamers gamer01 = Gamers.inputInfoGamers();
            gamer01.PrintGamer(gamer01);//вывели на экран какие параметры у игрока
            Gamers gamer02 = Gamers.inputInfoGamers();
            Gamers gamer03 = Gamers.inputInfoGamers();
            Gamers gamer04 = Gamers.inputInfoGamers();
            Gamers gamer05 = Gamers.inputInfoGamers();
            Gamers gamer06 = Gamers.inputInfoGamers();
            Gamers gamer07 = Gamers.inputInfoGamers();
            Gamers gamer08 = Gamers.inputInfoGamers();
            //распределили игроков на команды
            gamer01.AddGamersTeam1(gamer01,gamer02,gamer03,gamer04, comand1);
            gamer01.PrintTeam1(comand1);//вывели на экран из кого состоит наша команда
            gamer05.AddGamersTeam2(gamer05,gamer06,gamer07,gamer08, comand2);
            gamer05.PrintTeam2(comand2);//вывели на экран из кого состоит наша команда
            gamer01.Winner(gamer01, gamer02);//соревнование между двумя игроками согласно заданию в классе
            gamer01.TeamWinner(comand1, comand2);


          
        }
    }

}

