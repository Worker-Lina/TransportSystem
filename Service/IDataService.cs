using System.Collections.Generic;

namespace Service
{
    public interface IDataService
    {
        public List<Card> GetCardsByStatus(UserStatus status); // получить списк карт по статусу
    }
}
