using System;
using System.IO;
using static MyInterface.Convertabele;

namespace MyInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET.C#.06 Наследование.Интерфейсы и абстрактные классы");
            Console.WriteLine("Задание 1. Интерфейсы");

            ProgramConverter[] check = new ProgramConverter[2]; // создали массив элементов ProgramConverter 
            check[0] = new ProgramConverter(); // тип ProgramConverter
            check[1] = new ProgramHelper(); // тип ProgramHelper
            for (int i = 0; i < check.Length; i++) // проверка реализации метода ICodeChecker
            {
                if (check[i] is ICodeChecker) // если метод реализуется, вызываем метод проверки кода и соответствующий метод преобразования
                {
                    ICodeChecker codeCheck = check[i] as ProgramHelper;
                    if (codeCheck.CheckCodeSyntax("coding", "programmer")) Console.WriteLine(check[i].ConvertToCSharp("coding"));
                    else Console.WriteLine(check[i].ConvertToVB("coding"));
                }
                else // если метод не реализуется, вызываем два метода преоброзвания кода
                {
                    MyInterface.Convertabele.IConvertible convert = check[i] as ProgramConverter;
                    Console.WriteLine(convert.ConvertToCSharp("coding"));
                    Console.WriteLine(convert.ConvertToVB("coding"));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Задание 2. Класс Stream");

            Stream s = new MemoryStream();
            for (int i = 0; i < 122; i++)
            {
                s.WriteByte((byte)i);
            }
            s.Position = 0;

            // Now read s into a byte buffer with a little padding.
            byte[] bytes = new byte[s.Length + 10];
            int numBytesToRead = (int)s.Length;
            int numBytesRead = 0;
            do
            {
                // Read may return anything from 0 to 10.
                int n = s.Read(bytes, numBytesRead, 10);
                numBytesRead += n;
                numBytesToRead -= n;
                Console.WriteLine("number of bytes read: {0:d} %", 100*numBytesRead/(int)s.Length);
            } while (numBytesToRead > 0);
            s.Close();

            //Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Задание 3. Класс Stream");
            Console.WriteLine("Введите пароль:");

            string password = "";
            password = Console.ReadLine().ToString();

            if (password == "1")
            {
                Console.WriteLine("Пароль верный");

                s = new MemoryStream();
                for (int i = 0; i < 122; i++)
                {
                    s.WriteByte((byte)i);
                }
                s.Position = 0;

                // Now read s into a byte buffer with a little padding.
                bytes = new byte[s.Length + 10];
                numBytesToRead = (int)s.Length;
                numBytesRead = 0;
                do
                {
                    // Read may return anything from 0 to 10.
                    int n = s.Read(bytes, numBytesRead, 10);
                    numBytesRead += n;
                    numBytesToRead -= n;
                    Console.WriteLine("number of bytes read: {0:d} %", 100 * numBytesRead / (int)s.Length);
                } while (numBytesToRead > 0);
                s.Close();
            } else

            {
                Console.WriteLine("Пароль неверный");
            }

            Console.ReadLine();

        }
    }
}
