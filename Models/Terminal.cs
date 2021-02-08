using Abstract;
using Service;

namespace Models
{
    public class Terminal : ITerminal
    {
        public string GetInformation(Card card)
        {
            throw new System.NotImplementedException();
        }

        public void ToUpBalance(Card card, int sum)
        {
            throw new System.NotImplementedException();
        }

        public bool Validation(Card card, out string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
