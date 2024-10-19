using HealthGuru.Data.Models;
using Microsoft.Extensions.Options;

namespace HealthGuru.Data.Repositories;

public class ConnectionStrings
{
    public string FoodCatalog { get; set; }
}

public class FoodRepository(IOptions<ConnectionStrings> options)
{
    public async Task<IEnumerable<Food>> GetAllFoodsAsync()
    {
        return [new Food("Egg", 9.9, 12.2, 1.4), new Food("Oatmeal", 7, 14, 59), new Food("Ground Pork", 21.19, 16.88, 0)];
    }

    public async Task SaveFoodAsync(Food food)
    {

    }

    public async Task DeleteFoodAsync(string foodName)
    {

    }
}
