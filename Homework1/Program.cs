using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------Задание №3, 4, 5 (1)-------------------------------------------------
            Console.Title = "!=допрос";
            Console.WriteLine("Приветствую! Введите день своего рождения");
            string bday;
            bday= Console.ReadLine();
            string bmounth;
            Console.WriteLine("Введите месяц своего рождения");
            bmounth = Console.ReadLine();
            string byear, today;
            Console.WriteLine("Введите год своего рождения");
            byear = Console.ReadLine();
            //---------- Текущая дата----------
            today = DateTime.Now.ToString("dd.mm.yyy");
            int sub;
            Console.WriteLine("Сегодня \n"+today);
            Console.WriteLine(" Ваш день рождения - " + bday + "." +bmounth + "." + byear+". Всего прошло дней: " + sub);
            Console.ReadKey();
            //--------------------------------------------------------------Конец задания №2--------------------------------------------
            /*
            //-------------------------------------------------------------Задание №2 часть (2)---------------------------------------------
            string FName, SName;
            FName = Interaction.InputBox("Введите свое имя", "Ввод имени");
            SName = Interaction.InputBox("Введите свой возраст", "Ввод возраста");
            MessageBox.Show("Добро пожаловать, "+FName+", "+SName+"!", "Welcome", MessageBoxButtons.OK,MessageBoxIcon.Information);    
            //----------------------------------------------------------Задание №2 часть 2 конец-------------------------------------------
           // */
        }
    }
}
