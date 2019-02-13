using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // вводим кол-во чисел, он же размер массива
            int[] a = new int[n];    // создаем массив чисел

            string s = Console.ReadLine();  // считываем числа в строку
            string[] str = new string[n];   // создаем массив строк
            str = s.Split();     // записываем разделенные пробелом числа в массив из строк str

            for (int i = 0; i < n; i++)    // цикл по элементам массива
            {
                a[i] = int.Parse(str[i]);  // преобразовываем методом Parse числа из массива строк в массив чисел
            }
            int[] b = new int[n * 2]; // создаем новый массив чисел размером в два раза больше массива а[]
            int k = -1;        // коэффициент k
            for (int i = 0; i < n * 2; i++)    // цикл по массиву
            {
                if (i % 2 == 0)         // сдвигаем индекс элемента массива a[] только когда выбираем элемент из массива b  с четной позицией
                {
                    k++;
                }
                b[i] = a[k];      // заполняем массив b[]
            }
            for (int i = 0; i < n * 2; i++)   // цикл по массиву b 
            {
                Console.Write(b[i]);       // выводим элементы массива b через запятую
                Console.Write(' ');
            }

            Console.WriteLine("\n Для продолжения нажмите любую клавишу..."); // чтобы не закрывалось сразу при отладке
            Console.ReadKey(true);
        }
    }
}