namespace PharmacyApp.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Medicine> Medicines { get; set; }
}
