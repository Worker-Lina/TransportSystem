using Abstract;
using Models;
using System;

namespace UI
{
    public class Menu
    {
        public string[] Items { get; set; }
        public Terminal Terminal { get; set; }
        public Card Card { get; set; }

        public Menu() { }
        public Menu(string[] items)
        {
            Items = items;
        }


        public void Input(string[] items)
        {
            Items = items;
        }

        public void Print()
        {
            Console.WriteLine("\n\n\n\t\t-----------Меню--------------");
            for (int i = 0; i < Items.Length; i++)
            {
                Console.WriteLine($"\t\t{i + 1}. {Items[i]}");
            }
            Console.Write("\n\t -->");
        }

        public bool MainMenu(int choice)
        {
            bool result;
            switch (choice)
            {
                case 1:
                    Terminal.Validation(Card, out string message);
                    result = true;
                    break;
                case 2:
                    Terminal.ToUpBalance(Card, 5000);
                    result = true;
                    break;
                case 3:
                    Terminal.GetInformation(Card);
                    result = true;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }
    }
}
