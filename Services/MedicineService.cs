using PharmacyApp.Data;
using PharmacyApp.Entities;


namespace PharmacyApp.Services;

public class MedicineService
{
    private readonly PharmacyDbContext _context = new();

    public void AddMedicine()
    {
        Console.Write("name: ");
        var name = Console.ReadLine();

        Console.Write("barcode: ");
        var barcode = Console.ReadLine();

        Console.Write("price: ");
        var price = decimal.Parse(Console.ReadLine());

        Console.Write("stock: ");
        var stock = int.Parse(Console.ReadLine());

        var medicine = new Medicine
        {
            Name = name,
            Barcode = barcode,
            Price = price,
            Stock = stock,
            CategoryId = 1,
            SupplierId = 1
        };

        _context.Medicines.Add(medicine);
        _context.SaveChanges();
        Console.WriteLine("medicine added");
    }

    public void ListMedicines()
    {
        var meds = _context.Medicines.ToList();
        foreach (var m in meds)
        {
            Console.WriteLine($"{m.Id} | {m.Name} | {m.Price} azn | stock: {m.Stock}");
        }
    }
}
