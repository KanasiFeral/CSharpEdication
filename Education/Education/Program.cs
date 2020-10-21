﻿using System;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Переменные

            /*
             
            Типы переменных: 
                1. символ (char); 
                2. строка (string); 
                3. целое число (int); 
                4. число с плавающей запятой (double);
                5. логической (bool).
            
            Переменная - это то, что хранит значение одного типа.
            Как объявлять переменную: <тип> пробел <название> точка с запятой.
            Имя переменной не может начинатся с цифры, спецсимвола или точки.
            Пример (объявление переменной): int number;

            Также нужно задавать переменным базовое значение.
            Пример (объявление переменной с заданием ей базового значения): int number = 0;

            Задавать базовое значение нужно для того, чтобы при использовании этой переменной
            далее в программе не возникало ошибок. Если мы попытаемся использовать переменную без
            базового значения, то мы рискуем получить ошибку, т.к. в переменной нет значения, там 
            изначально пустота, а с пустотой мы не можем работать.

            Объявлять переменные одного типа можно в строку, через запятую.

            Именам переменных нужно давать внятные названия, чтобы из названия сразу было понятно,
            для чего используется переменная.
            
            */

            //int intWithValue = 0, intWithoutValue;

            //double doubleWithValue = 0.0, doubleWithoutValue;

            //string strWithValue = "Строка", strWithoutValue;

            //char chrWithValue = '$', chrWithoutValue;

            //bool boolWithValue = true, boolWithoutValue;

            #endregion

            #region Форматирование текста, вывод на экран

            /*
            
            Для вывода данных на экран используется конструкция Console.WriteLine() или Console.Write()
            WriteLine() - вывод с новой строки, Write() - вывод с текущей строки.
            Внутрь круглых скобок помещается то, что мы хотим вывести на экран.
            Пример: Console.WriteLine("Привет мир!");
            
            Выводить данные можно разными способами, берётся тот, что удобнее.

            \n - комбинация, после которой текст будет выводится с новой строки
            \t - комбинация, после которой текст будет иметь отступ в один tab

            */

            //Console.WriteLine("Привет, Я обучающая программа!");
            //Console.WriteLine("Этот текст на текущей строке\n\tА вот этот уже на новой и с табуляцией!");

            //Console.WriteLine("Вывод переменных объявленных выше:\n");

            //Console.WriteLine("Строка: " + strWithValue);
            //Console.WriteLine("Символ: " + chrWithValue);

            //Console.WriteLine($"Целое число: {intWithValue}");
            //Console.WriteLine($"Число с плавающей запятой: {doubleWithValue}");
            //Console.WriteLine($"Логическое значение: {boolWithValue}");

            #endregion

            #region Метематические опереции с данными

            /*
             
            С данными можно выполнять математические операции: 
                1. Сложение.
                2. Вычитание.
                3. Умножение.
                4. Деление.

            Со строками можно выполнять только сложение строк.
            
            */

            //int a = 10, b = 20;
            //int summ = a + b;

            //Console.WriteLine("Сумма a + b: " + summ);

            //Console.WriteLine("Сложение двух чисел (10 + 20): " + (10 + 20));
            //Console.WriteLine($"Сложение двух чисел (30 + 40): {30 + 40}");

            //Console.WriteLine("Вычитание двух чисел (10 - 20): " + (10 - 20));
            //Console.WriteLine($"Вычитание двух чисел (30 - 40): {30 - 40}");

            //Console.WriteLine("Умножение двух чисел (10 * 20): " + (10 * 20));
            //Console.WriteLine($"Умножение двух чисел (10 * 20): {30 * 40}");

            //Console.WriteLine("Деление двух чисел (100 / 20): " + (100 / 20));
            //Console.WriteLine($"Деление двух чисел (300 / 20): {300 / 20}");

            //Console.WriteLine("Много математических операций одновременно: " + ( (10 + 20) / (15 * 2) ));

            //double mathResult = (150 + 50) / (25 * 2);
            //Console.WriteLine($"Много математических операций одновременно: {mathResult}");

            //Console.WriteLine("Текст 1 " + " Текст 2");

            #endregion

            #region Методы: функции и процедуры

            /*
            
            Метод - это кусок кода, который можно вызывать по имени.
            Методы деляться на два типа: функция и процедура.

            Как объявлять метод? Пример: <модификатор доступа> <возвращаемое значение> <название>();

            Процедура - метод, который не возвращает значения void (пустой).
            Функция - метод, который возвращает любой тип данных, отличный от void (пустота).

            return - обязательное ключевое слово, для возврата значения

            Фигурные скобки у метода - это тело метода.

            Пример процедуры:
            static void ProcedureDisplay()
            {
                Console.WriteLine("Я процедура!");
                Console.WriteLine($"Вывожу на экран сумму двух чисел: { 10 + 50 }");
                Console.WriteLine("Маришка красавица!");
            }

            Display();

            Пример функции:
            static int FuncWithoutValues()
            {
                return 10 + 30;
            }

            Console.WriteLine(ReturnSumm());

            Методы также могут иметь входные параметры. С входными параметрами можно взаимодействовать только внутри метода.

            static int FuncWithValues(int firstValue, int secondValue)
            {
                int summ = firstValue + secondValue;

                return summ;
            }

            Слово static пишем из-за требований метода Main(). 
            Все методы объявленные в данном файле требуют дополнительный модификатор доступа static.            
            
            */

            // Вызов процедуры
            Trulalala();
            Trulalala();
            Trulalala();

            // Вызов функции
            Console.WriteLine(" TrulalaInt() " + TrulalaInt() );
            Console.WriteLine(" TrulalaInt() " + TrulalaInt() * 10 );
            Console.WriteLine(" TrulalaInt() " + TrulalaInt() + 20 + "\n");

            Console.WriteLine(" TrulalaString() " + TrulalaString() );
            Console.WriteLine(" TrulalaString() " + TrulalaString() + " плюс ещё текст");

            Console.WriteLine(FuncWithValues(5 , 5));
            Console.WriteLine(FuncWithValues(15 , 25));
            Console.WriteLine(FuncWithValues(50 , 50));

            #endregion

            // Задержка консоли
            Console.ReadLine();
        }

        // Функция
        static int TrulalaInt()
        {
            return 10;
        }

        static string TrulalaString()
        {
            return "ТЕКСТ";
        }

        // Процедура
        static void Trulalala()
        {
            int result = (100 + 100) / 25;
            Console.WriteLine(" Trulalala()  Результат: " + result);
            Console.WriteLine(" Trulalala()  TRULALALA 3X\n");
        }

        static void ProcedureDisplay()
        {
            Console.WriteLine("Я процедура!");
            Console.WriteLine($"Вывожу на экран сумму двух чисел: { 10 + 50 }");
            Console.WriteLine("Маришка красавица!");
        }

        static int FuncWithoutValues()
        {
            return 10 + 30;
        }

        static int FuncWithValues(int firstValue, int secondValue)
        {
            int summ = firstValue + secondValue;

            return summ;
        }
    }
}