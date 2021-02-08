using Abstract;
using Models;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Валидация", "Пополнить баланс", "Информация" };
            var menu = new Menu(items);
            var terminal = new Terminal();
            Card card = new UserCard() { Balance = 5000, BarcodeCard = "shtrih", IsWork = true, TariffPlans = Enum.TariffPlans.OneTripPrace, UserStatus = Enum.UserStatus.Child, СardNumber = "123123123" };


            string choice;

            do
            {
                Console.Clear();
                menu.Print();
                choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        terminal.Validation(card, out string message);
                        break;
                    case "2":
                        terminal.ToUpBalance(card, 5000);
                        break;
                    case "3":
                        terminal.GetInformation(card);
                        break;
                }

                Console.ReadKey();
            } while (choice != "3");
        }
    }
}
