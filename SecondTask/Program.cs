using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _surname = "Akulich";
            string _name = "Dmitriy";
            string _lastName = "Igorevich";
            byte _age = 27; 
            string _mail = "d_akulich@mail.ru";
            float _programScore = 5f;
            float _mathScore = 4.2f;
            float _phisicsScore = 4f;
            string _studentInfo= ($"Фамилия : {_surname} \nИмя : {_name} \nОтчество : {_lastName} \nВозраст : {_age} \nЭлектронная почта : {_mail}" +
                $" \nОценка за физику : {_programScore} \nОценка за математику : {_mathScore} \nОценка за физику : {_phisicsScore}");

            Console.WriteLine(_studentInfo);
            Console.WriteLine("Нажмите Enter для получение ифнормации по оценкам...");
           while (Console.ReadKey().Key != ConsoleKey.Enter) { }


            float _generalScore;
            float _averageScore;
            
            _generalScore = _programScore + _mathScore + _phisicsScore; 
            _averageScore =  _generalScore / 3;

            Console.WriteLine($"Сумма балов по всем предметам : {_generalScore} \nСредний балл : {_averageScore}");
            Console.ReadKey();
        }
    }
}
