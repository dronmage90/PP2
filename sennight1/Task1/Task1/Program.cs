using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            bool f(int b)   // создаем функцию типа bool
            {
                if (b == 1)   // если еденица то возвращаем false
                {
                    return false;
                }
                int k = 0;       // количество делителей числа - k
                for (int i = 2; i < b; i++)    // прокручиваем все числа от двух до числа ( не включая )
                {
                    if (b % i == 0) { k++; }   // проверяем делимость на все, если делится, то увеличиваем счетчик k
                }
                if (k == 0)    // если не нашлось ни одного делителя возвращаем true ( число простое )
                {
                    return true;
                }

                else return false;  // в противном случае возвращаем false ( число не простое )
            }
            int cnt = 0;       // счетчик простых чисел
            int n = int.Parse(Console.ReadLine());   // считываем количество чисел, которые будем проверять

            string[] str = new string[n];   // новый массив из строк
            string s = Console.ReadLine();    // считываем все числа в одну строку
            str = s.Split();    // разделяем их ( по пробелу ) и записываем каждое число в массив str как строку


            int[] a = new int[n];     //новый массив из чисел


            for (int i = 0; i < n; i++)      // цикл по элементам массива
            {
                a[i] = int.Parse(str[i]);    // преобразуем методом Parse из строк в числа и записываем в массив a[] 
            }



            for (int i = 0; i < n; i++) // цикл по элементам массива
            {
                if (f(a[i]) == true)    // проверяем функцией f простое ли число
                {
                    cnt++;  // если простое, увеличиваем счетчик простых чисел cnt
                }
            }
            Console.WriteLine(cnt);   // выводим кол-во простых чисел ( счетчик cnt )
            for (int i = 0; i < n; i++)  // цикл по элементам массива
            {
                if (f(a[i]) == true)     // если число простое
                {
                    Console.Write(a[i]);    // выводим простые числа через пробел 
                    Console.Write(' ');
                }
            }


            Console.WriteLine("\n Для продолжения нажмите любую клавишу..."); // чтобы не закрывалась сразу при отладке
            Console.ReadKey(true);

        }
    }
}