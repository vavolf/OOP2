using System;
using System.Text;
namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool alive = true;
            byte bit1 = 1;
            sbyte bit2 = -1;
            short n1 = 1;
            ushort n2 = 1;
            int a1 = -10;
            uint a2 = 10;
            long a3 = -100;
            ulong a4 = 100;
            float b1 = 2.2F;
            double b2 = 2.2;
            decimal d1 = 2.2M;
            char ch1 = 'A';
            string str = "AA";
            object ob1 = 2;
            object ob2 = 2.2;
            object ob3 = "AAA";


            Console.WriteLine(alive);
            Console.WriteLine(bit1);
            Console.WriteLine(bit2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(d1);
            Console.WriteLine(ch1);
            Console.WriteLine(str);
            Console.WriteLine(ob1);
            Console.WriteLine(ob2);
            Console.WriteLine(ob3);

            // ввод переменной
            Console.WriteLine("Ввод вывод int");
            Console.WriteLine(b1);
            Console.WriteLine("Введите переменную int: ");
            string v = Console.ReadLine();
            a1 = Int32.Parse(v);
            Console.WriteLine(a1);

            // неявное преобразование
            Console.WriteLine();
            int q1 = bit1;
            q1 = bit2;
            q1 = n1;
            q1 = n2;
            // явное преобразование
            int q2 = (int)bit1;
            q2 = (int)bit2;
            q2 = (int)n1;
            q2 = (int)n2;
            q2 = (int)a2;
            q2 = (int)a3;
            byte q3 = (byte)q1;

            //упаковка значимых типов
            int z = 21;
            object z1 = z;
            //распаковка
            int z2 = (int)z1;

            // неявная типизация
            var strr = "вывод неявной типизации";
            var c = 20;
            Console.WriteLine(c.GetType().ToString());
            Console.WriteLine(strr.GetType().ToString());

            // Nullable
            int? x = 2;
            Console.WriteLine(x.Value);

            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
                Console.WriteLine("x is equal to null");

            // изменяем стандартное значение
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            x = 10;
            Console.WriteLine(x.HasValue);

            // явное преобрзование
            int? x1 = null;
            if (x1.HasValue)
            {
                int x2 = (int)x1;
                Console.WriteLine(x2);
            }
            // неявное преобрзование
            x1 = 4;
            int? x3 = x1;
            Console.WriteLine(x3);


            // СТРОКИ
            // сравнение
            string s1 = "hello";
            string s2 = "hello";

            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("s1 < s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("s1 > s2");
            }
            else
            {
                Console.WriteLine("s1 = s2 ");
            }

            // соединение
            string f1 = "hello";
            string f2 = "world";
            string f3 = f1 + " " + f2; // результат: строка "hello world"
            string f4 = String.Concat(f3, "!!!"); // результат: строка "hello world!!!"
            Console.WriteLine(f4);


            // копирование
            string f6 = f1;
            Console.WriteLine(f6);
#pragma warning disable CS0618 // Тип или член устарел
            f6 = String.Copy(f2);
#pragma warning restore CS0618 // Тип или член устарел
            Console.WriteLine(f6);

            // подстрока
            string subf = "hello";
            int index = f3.IndexOf(subf);
            int index2 = subf.Length;
            Console.WriteLine(index);
            Console.WriteLine(index2);
            string select = f3.Substring(index, index2);
            Console.WriteLine(select);

            // разделение
            string[] separate = f3.Split(new char[] { ' ' });

            foreach (string s in separate)
            {
                Console.WriteLine(s);
            }

            // пустые строки
            string y1 = null;
            string y2 = "";
            string y3 = new String('a', 6);
            Console.WriteLine(String.IsNullOrEmpty(y1));
            Console.WriteLine(String.IsNullOrEmpty(y2));
            Console.WriteLine(String.IsNullOrEmpty(y3));

            //StringBuilder
            StringBuilder y4 = new StringBuilder("ПРИВЕТ");
            y4.Insert(0, "ВСЕМ ");
            y4.Append(" РАБОТЯГИ");
            Console.WriteLine(y4);
            y4.Remove(5,15);
            y4.Append("КУ РАБОТЯГИ");
            Console.WriteLine(y4);

            // МАССИВЫ
            // двухмерный массив

            int[,] numberx = { { 1, 2, 3 }, { 4, 5, 6 } };

            int i = 0;
            int j = 0;
            int rows = numberx.GetUpperBound(0) + 1;    // количество строк
            int columns = numberx.Length / rows;        // количество столбцов
            
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                {
                    Console.Write($"{numberx[i, j]}");
                }
                Console.WriteLine();
            }

            // строчный массив
             i = 0;
            string[] string1 = { "аку", "ла", "вы", "шла", "на", "ра", "бо", "ту" };
            Console.WriteLine("длинна масива");
            Console.WriteLine($"{string1.Length}");
            while (i != string1.Length)
            {
                Console.Write($"{string1[i]} \t");
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("Какой слог хотите поменять: ");
            v = Console.ReadLine();
            int lol = Int32.Parse(v) - 1;
            Console.WriteLine("Введите что хотите вставить: ");
            v = Console.ReadLine();    
            
            string1[lol] = v;
            i = 0;            
            while (i != string1.Length)
            {
                Console.Write($"{string1[i]} \t");
                i++;
            }
            Console.WriteLine();

            // зубчатый массив
            
            var numbers = new[] {
                 new[] { 1, 2 },
                 new[] { 1, 2, 3 },
               new[] { 1, 2, 3, 4, 5 }
            };

            foreach (var row in numbers)
            {
                foreach (float number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            for (i = 0; i < numbers.Length; i++)
            {
                for (j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} \t");
                }
                Console.WriteLine();
            }

            // зубчатый массив вещественных

            var numbers23 = new [] {
                 new float[2] ,
                 new float[3] ,
                 new float[5] 
            };

            float kjk = 0;
            Console.WriteLine( $"значение длины{numbers23.Length}");
            int lolka = numbers23[1].Length;
            Console.WriteLine($"значение длины{numbers23[2].Length}");

            for (i = 0; i < numbers23.Length; i++)
            {
                for (j = 0; j < numbers23[i].Length; j++)
                {
                    
                    kjk = Convert.ToSingle(Console.ReadLine());
                    numbers23[i][j]= kjk;
                }
                Console.WriteLine();
            }

            foreach (var row in numbers23)
            {
                foreach (float number23 in row)
                {
                    Console.Write($"{number23} \t");
                }
                Console.WriteLine();
            }



            //неявно тип пер для хванения массива и строк
            var masiv = numbers;
            var stroka0 = masiv[0];
            Console.WriteLine(stroka0[0]);
            Console.WriteLine(stroka0[1]);

            // КОРТЕЖИ

            //вывод значений
            (int, string, char, string, ulong) multik = (25,"Tom", '&', "jerry", 25);
            Console.Write(multik.Item1);
            Console.Write(multik.Item2);
            Console.Write(multik.Item3);
            Console.Write(multik.Item4);
            Console.WriteLine(multik.Item5);


            //распаковка кортежа
            object pa1 = null;
            object pa2 = null;
            object pa3 = null;
            object pa4 = null;
            object pa5 = null;
            
            (pa1, pa2, pa3, pa4, pa5) = multik;

            Console.Write(pa1 = multik.Item1);
            Console.Write(pa2 = multik.Item2);
            Console.Write(pa3 = multik.Item3);
            Console.Write(pa4 = multik.Item4);
            Console.WriteLine(pa5 = multik.Item5);

            var ( pd1,  pd2, pd3,  pd4, pd5) = multik;
            Console.Write(pd1);
            Console.Write(pd2);
            Console.Write(pd3);
            Console.Write(pd4);
            Console.WriteLine(pd5);

            (int ps1, string ps2, char ps3, string ps4, ulong ps5) = multik;
            Console.Write(ps1);
            Console.Write(ps2);
            Console.Write(ps3);
            Console.Write(ps4);
            Console.WriteLine(ps5);

            // используем (_) - пропуски
            var (ik1,ik2, _ , ik4 , _) = multik;
            Console.WriteLine(ik4);

            //сравнение кортежей
            (int,int) mul = (25,25);
            (int, int) mul1 = (25, 25);
            (int, string) mul3 = (19, "25");

            bool equ1 = mul == mul1;
            bool equ2 = mul.Item1 == mul3.Item1;
            bool equ3 = mul.Item1 == Int32.Parse(mul3.Item2);

            Console.WriteLine(equ1);
            Console.WriteLine(equ2);
            Console.WriteLine(equ3);

            // локальная функция с кортежем
            void Compare(int[] s1, string s2)
            {
                
                int a = s1[0];
                int k = s1.Length - 1;
                int aa = s1[k];
                int s1Sum = 0;
                foreach (int s in s1)
                    s1Sum += s;
                string aaa = s2.Substring(0, s2.Length - s2.Length +1);
                (int a1,int a2,int a3,string a4) lol  = (a,aa,s1Sum,aaa);
                Console.WriteLine(lol);
            }

            int[] massiv = { 1, 2, 3 };
            string stroka= "fsaf";

            Compare(massiv, stroka);

            // checked and unchecked

            int g = 2147483647;


            void Compare1(int s1)
            {
                try
                {
                    int c = checked((int)(s1 + 100));
                    Console.WriteLine(c);
                }
                catch
                {
                    Console.WriteLine("ошибка");
                }
                
            }
            Compare1(g);

            void Compare2(int s1)
            {
                try
                {
                    int c = unchecked((int)(s1 + 100));
                    Console.WriteLine(c);
                }
                catch
                {
                    Console.WriteLine("ошибка");
                }

            }

            Compare2(g);


            

        }

    }
}