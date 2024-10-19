namespace HealthGuru.Data.Models;

public record Food(string Name, double Fat, double Protein, double Carbohydrates, List<string> Tags = default!)
{
    // https://www.nal.usda.gov/programs/fnic
    public double Calories => (Fat * 9) + (Protein * 4) + (Carbohydrates * 4);

    public bool HasTags => Tags?.Count > 0;
};