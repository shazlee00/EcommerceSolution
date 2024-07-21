using Entities.Models;
using Entities.Repository;

namespace Data.RepositoryConc
{
    public interface IShoppingCartRepository:IGRepository<ShoppingCart>
    {
        void Increase(ShoppingCart shoppingCart, int count);
        void Decrease(ShoppingCart shoppingCart, int count);
    }
}