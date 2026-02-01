namespace PharmacyApp.Entities;

public class Supplier
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Phone { get; set; }

    public List<Medicine> Medicines { get; set; }
}
