
using System.Linq;


namespace DrinkStores.Models
{
    public class IStoreRepository
    {
        IQueryable<Drink> Drinks { get; }
    }
}
