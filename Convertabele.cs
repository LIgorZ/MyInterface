using System;
using System.Collections.Generic;
using System.Text;

namespace MyInterface
{
    class Convertabele
    {
        public interface IConvertible // реализуем интерфейс IConvertible
        {
            string ConvertToCSharp(string toSharp); // реализуем метод ConvertToSharp, который возвращает строку
            string ConvertToVB(string toVB); // реализуем метод ConvertToVB, который возвращает строку
        }

        public interface ICodeChecker // ( создание нового интерфейса, опредилив метод CheckCodeSyntax )
        {
            bool CheckCodeSyntax(string str1, string str2); // метод принимает 2 строки (строка для проверки и используемый язык) тип данных bool
        }
        public class ProgramHelper : ProgramConverter, ICodeChecker // создаем класс ProgramHelper, который реализует IConvertible + добавили наследование от IcodeChecker
        {
            public string ConvertToCSharp(string toSharp)
            {
                return "ProgramHelper_toCSharp"; // простые строковые сообщения для имитации преоброзования
            }

            public string ConvertToVB(string toVB)
            {
                return "ProgramHelper_toVB"; // простые строковые сообщения для имитации преоброзования
            }

            public bool CheckCodeSyntax(string str, string lang)
            {
                return true;
            }
        }

        public class ProgramConverter : IConvertible // класс ProgramConverter реализует интерфейс IConvertible
        {
            public string ConvertToCSharp(string toSharp) // опредилили первый  метод конвертации
            {
                return "ProgramConverter_toCSharp";
            }

            public string ConvertToVB(string toVB) // опредилили второй метод конвертации
            {
                return "ProgramConverter_toVB";
            }
        }
    }
}
