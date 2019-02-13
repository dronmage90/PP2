﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Task1
{
    class Layer
    {
        int selectedItemIndex;
        public FileSystemInfo[] Items
        {
            get;
            set;
        }

        public int SelectedItemIndex
        {
            get
            {
                return selectedItemIndex;
            }
            set
            {
                if (value >= Items.Length)
                {
                    selectedItemIndex = 0;
                }
                else if (value < 0)
                {
                    selectedItemIndex = Items.Length - 1;
                }
                else
                {
                    selectedItemIndex = value;
                }
            }
        }

        public Layer(FileSystemInfo[] items)
        {
            selectedItemIndex = 0;
            this.Items = items;
        }
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            for (int i = 0; i < Items.Length; ++i)
            {
                if (i == selectedItemIndex)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine(Items[i].Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Explorer";
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");


            Stack<Layer> history = new Stack<Layer>();

            history.Push(new Layer(dirInfo.GetFileSystemInfos()));

            bool quit = false;
            while (!quit)
            {
                history.Peek().Draw();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    history.Peek().SelectedItemIndex--;
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    history.Peek().SelectedItemIndex++;
                }
                else if (pressedKey.Key == ConsoleKey.Enter)
                {
                    int x = history.Peek().SelectedItemIndex;
                    DirectoryInfo y = history.Peek().Items[x] as DirectoryInfo;
                    history.Push(new Layer(y.GetFileSystemInfos()));
                }
                else if (pressedKey.Key == ConsoleKey.Backspace)
                {
                    history.Pop();
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    quit = true;
                }
            }
        }
    }
}