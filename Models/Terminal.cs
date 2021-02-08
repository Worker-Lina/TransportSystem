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
            // TODO
            throw new System.NotImplementedException();
        }

        public void ToUpBalance(Card card, int sum)
        {
            // TODO
            throw new System.NotImplementedException();
        }

        public bool Validation(Card card, out string message)
        {
            // TODO
            throw new System.NotImplementedException();
        }
    }
}
