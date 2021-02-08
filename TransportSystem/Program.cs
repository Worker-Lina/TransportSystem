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

            Console.Write("Введите номер карты: ");
            string cardNumber = Console.ReadLine();

            Card card = new UserCard
            {
                Balance = 5000,
                BarcodeCard = "shtrih",
                IsWork = true,
                TariffPlans = Enum.TariffPlans.OneTripPrace,
                UserStatus = Enum.UserStatus.Child,
                СardNumber = cardNumber
            };

            var menu = new Menu {
                Items = items,
                Terminal = new Terminal(),
                Card = card
            };

            int choice;

            do
            {
                Console.Clear();
                menu.Print();
                
                int.TryParse(Console.ReadLine(), out choice);

            } while (menu.MainMenu(choice));
        }
    }
}
