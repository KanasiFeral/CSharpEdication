using System;

namespace Education
{
    class Program
    {
        #region Документация

        #region Тема 1. Переменные

        /*
        
            Типы переменных: 
                1. символ (char); 
                2. строка (string); 
                3. целое число (int); 
                4. число с плавающей запятой (double);
                5. логической (bool).
            
            Переменная - это то, что хранит значение одного типа: строка, число, символ и т.д.
            Как объявлять переменную: <тип> <название> | int(тип) nameVaraible(название);

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

        #endregion

        #region Тема 2. Форматирование текста, вывод данных

        /*
        
            Для вывода данных на экран используется конструкция Console.WriteLine() или Console.Write()
            WriteLine() - вывод с новой строки, Write() - вывод с текущей строки.
            Внутрь круглых скобок помещается то, что мы хотим вывести на экран.
            Пример: Console.WriteLine("Привет мир!");
            
            Выводить данные можно разными способами, берётся тот, что удобнее.

            \n - комбинация, после которой текст будет выводится с новой строки
            \t - комбинация, после которой текст будет иметь отступ в один tab
         
        */

        #endregion

        #region Тема 3. Математические операции

        /*
             
            С данными можно выполнять математические операции: 
                1. Сложение.
                2. Вычитание.
                3. Умножение.
                4. Деление.

            Со строками можно выполнять только сложение строк.
            
        */

        #endregion

        #region Тема 4. Методы: функции, процедуры

        /*
            
            Метод - это кусок кода, который можно вызывать по имени.
            Методы деляться на два типа: функция и процедура.

            Как объявлять метод? Пример: <модификатор доступа> <возвращаемое значение> <название>();

            Процедура - что-то делает, например: собака гуляет на улице
            Функция - что-то возвращает, например: собака возвращает кинутый ей мячик.

            return - обязательное ключевое слово, для возврата значения

            Фигурные скобки у метода - это тело метода.

            Методы также могут иметь входные параметры. С входными параметрами можно взаимодействовать только внутри метода.
            Входные параметры, это то, что пишется в круглый скобках после имени метода.

            Слово static пишем из-за требований метода Main(). 
            Все методы объявленные в данном файле требуют дополнительный модификатор доступа static.            
            
        */

        #endregion

        #region Тема 5. Циклы

        /*
         
            Цикл - действие, которое повторяется N количество раз. N - количество повторений.
            
            Существует 4 вида циклов:
                1. Цикл с итератором for;
                2. Цикл с условием while;
                3. Цикл с постусловием do while;
                4. Цикл коллекции foreach.

            1. Цикл for имеет итератор. Итератор - выражение вычислямое после каждого шага цикла. 
            Если по простому, то это шаг-позиция, на которой сейчас находится цикл.
         
            2. Цикл while выполняется до тех пор, пока выполняется условие. Цикл может даже не начать выполняться, 
            если условие не выполняется. 

            3. Цикл do while отличается от while лишь тем, что он в любом случае выполнится хотя бы 1 раз, даже если
            условие не позволяет выполнить цикл.

            4. Цикл foreach работает с коллекциями любых размеров. Имеет встроенный итератор, это мы изучим в следующих темах.

            Существуют так же бесконечные циклы, это такой цикл, у которого нет условия выхода из цикла.
            Выполняется бесконечно, или пока его не прервут изнутри, например по какому-то условию.

            break - выход из цикла.
            continue - пропустить текущий шаг.

        */

        #endregion

        #region Тема 6. Перегрузка методов

        #endregion

        #region Тема 7. Передача параметров по ссылке и значению. Выходные параметры

        #endregion

        #region Тема 8. Условия if else / switch case

        #endregion

        #region Тема 9. Массивы, коллекции, цикл foreach

        #endregion

        #region Тема 10. Массив параметров и ключевое слово params

        #endregion

        #region Тема 11. Перечисления enum

        #endregion

        #region Тема 12. Рекурсивные функции

        #endregion

        #region Тема 13. Кортежи

        #endregion

        #region Тема 14. Модификаторы доступа. Public / private / protected / internal / protected internal / private protected

        #endregion

        #region Тема 15. Обработка исключений. Конструкция try..catch..finally

        #endregion

        #region Тема 16. Классы

        #endregion

        #region Тема 17. Свойства

        #endregion

        #region Тема 18. Статические члены и модификатор static

        #endregion

        #region Тема 19. Интерфейсы

        #endregion

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в обучающую программу!");

            #region Переменные

            Console.WriteLine("\n\tПЕРЕМЕННЫЕ\n");

            // 
            int int1 = 0, int2 = 10;
            Console.WriteLine($"Переменные типа int: {int1}, {int2}");

            double double1 = 0.0, double2 = 52.2;
            Console.WriteLine($"Переменные типа double: {double1}, {double2}");

            string string1 = "Строка", string2 = "456";
            Console.WriteLine($"Переменные типа string: {string1}, {string2}");

            char char1 = '$', char2 = 'A';
            Console.WriteLine($"Переменные типа string: {char1}, {char2}");

            bool bool1 = true, bool2 = false;
            Console.WriteLine($"Переменные типа bool: {bool1}, {bool2}");

            Console.WriteLine("\n-------------------------------------------\n");

            #endregion

            #region Форматирование текста, вывод на экран

            Console.WriteLine("\n\tФОРМАТИРОВАНИЕ ТЕКСТА, ВЫВОД НА ЭКРАН\n");

            Console.WriteLine("Этот текст на текущей строке\n\tА вот этот уже на новой и с табуляцией!");

            Console.WriteLine("Вывод переменных объявленных выше:\n");

            Console.WriteLine("Строка: " + string1);
            Console.WriteLine("Символ: " + char1);

            Console.WriteLine($"Целое число: {int1}");
            Console.WriteLine($"Число с плавающей запятой: {double1}");
            Console.WriteLine($"Логическое значение: {bool1}");

            Console.WriteLine("\n-------------------------------------------\n");

            #endregion

            #region Метематические опереции с данными

            Console.WriteLine("\n\tМАТЕМАТИЧЕСКИЕ ОПЕРАЦИИ С ДАННЫМИ\n");

            int a = 10, b = 20;
            int summ = a + b;

            Console.WriteLine("Сумма a + b: " + summ);

            Console.WriteLine("Сложение двух чисел (10 + 20): " + (10 + 20));
            Console.WriteLine($"Сложение двух чисел (30 + 40): {30 + 40}");

            Console.WriteLine("Вычитание двух чисел (10 - 20): " + (10 - 20));
            Console.WriteLine($"Вычитание двух чисел (30 - 40): {30 - 40}");

            Console.WriteLine("Умножение двух чисел (10 * 20): " + (10 * 20));
            Console.WriteLine($"Умножение двух чисел (10 * 20): {30 * 40}");

            Console.WriteLine("Деление двух чисел (100 / 20): " + (100 / 20));
            Console.WriteLine($"Деление двух чисел (300 / 20): {300 / 20}");

            Console.WriteLine("Много математических операций одновременно: " + ((10 + 20) / (15 * 2)));

            double mathResult = (150 + 50) / (25 * 2);
            Console.WriteLine($"Много математических операций одновременно: {mathResult}");

            Console.WriteLine("Текст 1 " + " Текст 2");

            Console.WriteLine("\n-------------------------------------------\n");

            #endregion

            #region Методы: функции и процедуры

            Console.WriteLine("\n\tМЕТОДЫ: ФУНКЦИИ И ПРОЦЕДУРЫ\n");

            Console.WriteLine($"Результат работы функции returnInt(): {returnInt()}");
            Console.WriteLine($"Результат работы функции returnDouble(): {returnDouble()}");
            Console.WriteLine($"Результат работы функции returnString(): {returnString()}");
            Console.WriteLine($"Результат работы функции returnChar(): {returnChar()}");
            Console.WriteLine($"Результат работы функции returnBoolTrue(): {returnBoolTrue()}");
            Console.WriteLine($"Результат работы функции returnBoolFalse(): {returnBoolFalse()}");

            Console.WriteLine($"Результат работы функции returnValueInt(int val): {returnValueInt(10)}");
            Console.WriteLine($"Результат работы функции returnValueDouble(double val): {returnValueDouble(85.5)}");
            Console.WriteLine($"Результат работы функции returnValueString(string val): {returnValueString("Строка с данными! + 452282")}");
            Console.WriteLine($"Результат работы функции returnValueChar(char val): {returnValueChar('$')}");
            Console.WriteLine($"Результат работы функции returnValueBool(bool val): {returnValueBool(true)}");
            Console.WriteLine($"Результат работы функции returnValueBool(bool val): {returnValueBool(false)}");

            Console.WriteLine($"Результат работы функции returnSumm(int number1, int number2): {returnSumm(10, 50)}");
            Console.WriteLine($"Результат работы функции (double d1, double d2, double d3): {(50.555, 85.55455, 10.5)}");
            Console.WriteLine($"Результат работы функции percent(int numeric, int percent, string name): {percent(20, 100, "Гладиолус")}");

            DisplayReturnSumm(10, 15);
            DisplayReturnSummWithDefaultValues();
            DisplayReturnSummWithDefaultValues(10);
            DisplayReturnSummWithDefaultValues(10, 50);
            DisplayReturnInt();
            DisplayReturnValueString("Бамбук");


            Console.WriteLine("\n-------------------------------------------\n");

            #endregion

            #region Циклы

            // Цикл с итератором
            // i++ - i + 1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"for Позиция: {i}");
            }

            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            // Цикл с шагом 2
            // i = i + 2 | i +=2
            // i = i - 2 | i -=2
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine($"for Позиция: {i}");
            }

            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            // Цикл от 10 до 0 включительно
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"for Позиция: {i}");
            }

            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            // Цикл с условием
            int whileI = 0;
            
            // 10 < 10 ? - нет. Цикл выполняться не будет
            while (whileI < 10)
            {
                Console.WriteLine($"while Позиция: {whileI}");

                whileI++;
            }

            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            int doI = 10;
            // Цикл с постусловием
            do
            {
                Console.WriteLine($"doWhile Позиция: {doI}");

                doI++;
            }
            // 10 < 10 ? - нет. Он выполнится 1 раз
            while (doI < 10);

            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            // Цикл от 10 до 0 включительно
            int whileI1 = 10;

            while (whileI1 >= 0)
            {
                Console.WriteLine($"While Позиция: {whileI1}");

                whileI1--;
            }

            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            // Цикл doWhile от 10 до 0 включительно
            int doI1 = 10;
            do
            {
                Console.WriteLine($"DoWhile Позиция: {doI1}");

                doI1--;
            } while (doI1 >= 0);

            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            // Использование break и continue
            for (int i = 0; i < 10; i++)
            {
                // Остановить цикл когда итератор равен 7
                if (i == 7)
                {
                    // Выйти из цикла
                    break;
                }

                // Пропустить 3 шаг
                if (i == 3)
                {
                    // Пойти дальше
                    continue;
                }

                Console.WriteLine($"for break/continue: {i}");
            }
            
            // Вставка пустой строки для более приятного отображения данных на экране
            Console.WriteLine();

            // Цикл с использованием double
            for (double i = 0.0; i < 1.5; i += 0.1)
            {
                Console.WriteLine($"for double: {i}");
            }

            #endregion

            // Задержка консоли
            Console.ReadLine();
        }

        #region Функции без входных параметров. Возвращают какое-то значение

        static int returnInt()
        {
            return 10;
        }

        static double returnDouble()
        {
            return 25.5;
        }

        static string returnString()
        {
            return "Строка данных";
        }

        static char returnChar()
        {
            return '$';
        }

        static bool returnBoolTrue()
        {
            return true;
        }

        static bool returnBoolFalse()
        {
            return false;
        }

        #endregion

        #region Функции с одним входным параметром. Возвращают этот входной параметр

        static int returnValueInt(int val)
        {
            return val;
        }

        static double returnValueDouble(double val)
        {
            return val;
        }

        static string returnValueString(string val)
        {
            return val;
        }

        static char returnValueChar(char val)
        {
            return val;
        }

        static bool returnValueBool(bool val)
        {
            return val;
        }

        #endregion

        #region Функции с несколькими входными параметрами

        static int returnSumm(int number1, int number2)
        {
            return number1 + number2;
        }

        static double threeDoubleParams(double d1, double d2, double d3)
        {
            return ((d1 + d2) / 100) * d3;
        }

        static string percent(int numeric, int percent, string name)
        {
            double result = (numeric / 100) * percent;

            return $"{percent}% от числа {numeric} равен {result}, потому что {name}";
        }

        #endregion

        #region Процедуры

        static void DisplayReturnSumm(int number1, int number2)
        {
            Console.WriteLine($"Результат работы процедуры DisplayReturnSumm(int number1, int number2): {returnSumm(number1, number2)}");
        }

        static void DisplayReturnSummWithDefaultValues(int number1 = 50, int number2 = 100)
        {
            Console.WriteLine($"Результат работы процедуры DisplayReturnSummWithDefaultValues(int number1 = 50, int number2 = 100): {returnSumm(number1, number2)}");
        }

        static void DisplayReturnInt()
        {
            Console.WriteLine($"Результат работы процедуры DisplayReturnInt(): {returnInt()}");
        }

        static void DisplayReturnValueString(string val)
        {
            Console.WriteLine($"Результат работы процедуры DisplayReturnValueString(string val): {returnValueString(val)}");
        }

        #endregion
    }
}