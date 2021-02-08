using Abstract;
using Service;

namespace Models
{
    public class Terminal : ITerminal
    {
        public ILogger Logger { get; set; }

        public Terminal() {
            Logger = new ConsoleLogger();
        }

        public Terminal(ILogger logger)
        {
            Logger = logger;
        }

        public string GetInformation(Card card)
        {
            string info = $"{card.RegistrationDate}\nBalanse: {card.Balance}\nNumber: {card.СardNumber}";
            if (card is UserCard)
            {
                info += $"{card.UserStatus}";
            }
            return info;

        }

        public void ToUpBalance(Card card, int sum)
        {
            card.Balance += sum;
        }

        public bool Validation(Card card, out string message)
        {
            // TODO
            if (card is BeneficiariesCard)
            {
                message = "Успешная валидация";
                return true;
            }

            message = "Успешная валидация";
            return true;
        }
    }
}
