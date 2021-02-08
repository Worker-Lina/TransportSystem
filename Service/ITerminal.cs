namespace Service
{
    public interface ITerminal
    {
        public bool Validation(Card card, out string message); // провести валидацию
        public void ToUpBalance(Card card, int sum); // пополнить счет
        public string GetInformation(Card card); // получить информацию о карте
    }
}
