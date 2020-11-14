
using System.Linq;


namespace DrinkStores.Models
{
    public interface IStoreRepository
    {
        IQueryable<Drink> Drinks { get; }
    }
}
