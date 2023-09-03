using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
            {
            new IndexOutOfRangeException("Исключение типа IndexOutOfRangeException"),
            new FileNotFoundException("Исключение типа FileNotFoundException"),
            new DivideByZeroException("Исключение типа DivideByZeroException"),
            new NullReferenceException("Исключение типа NullReferenceException"),
            new CustomException("Собственное исключение")
            };
            try
            {
                foreach (var ex in exceptions)
                {
                    try
                    {
                        throw ex;
                    }
                    catch (Exception innerEx)
                    {
                        Console.WriteLine("Исключение: " + innerEx.Message);
                    }
                }
            }
            finally
            {
                Console.WriteLine("Блок finally выполнен.");
            }
        }
    }
}

