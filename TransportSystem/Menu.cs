﻿using System;


namespace UI
{
    public class Menu
    {
        private string[] items;

        public Menu() { }
        public Menu(string[] items)
        {
            this.items = items;
        }


        public void Input(string[] items)
        {
            this.items = items;
        }

        public void Print()
        {
            Console.WriteLine("\n\n\n\t\t-----------Меню--------------");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"\t\t{i + 1}. {items[i]}");
            }
            Console.Write("\n\t -->");
        }
    }
}
