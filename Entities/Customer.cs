namespace PharmacyApp.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }

    public List<Sale> Sales { get; set; }
}
