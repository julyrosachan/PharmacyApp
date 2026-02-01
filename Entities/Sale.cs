namespace PharmacyApp.Entities;

public class Sale
{
    public int Id { get; set; }
    public DateTime SaleDate { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public List<SaleItem> SaleItems { get; set; }
}
