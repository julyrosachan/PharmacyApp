using Microsoft.EntityFrameworkCore;
using PharmacyApp.Data;
using PharmacyApp.Entities;

namespace PharmacyApp.Services;

public class SaleService
{
    private readonly PharmacyDbContext _context = new();

    public void SellMedicine()
    {
        Console.Write("customer name: ");
        var cname = Console.ReadLine();

        Console.Write("customer phone: ");
        var phone = Console.ReadLine();

        var customer = new Customer
        {
            FullName = cname,
            Phone = phone
        };

        Console.Write("medicine id: ");
        int medId = int.Parse(Console.ReadLine());

        Console.Write("quantity: ");
        int qty = int.Parse(Console.ReadLine());

        var medicine = _context.Medicines.Find(medId);
        if (medicine == null || medicine.Stock < qty)
        {
            Console.WriteLine("❌ not enough stock");
            return;
        }

        medicine.Stock -= qty;

        var sale = new Sale
        {
            SaleDate = DateTime.Now,
            Customer = customer,
            SaleItems = new List<SaleItem>
            {
                new SaleItem
                {
                    MedicineId = medId,
                    Quantity = qty,
                    UnitPrice = medicine.Price
                }
            }
        };

        _context.Sales.Add(sale);
        _context.SaveChanges();
        Console.WriteLine("🧾 sale completed");
    }

    public void ShowCustomersWithPurchases()
    {
        var customers = _context.Customers
            .Include(c => c.Sales)
            .ThenInclude(s => s.SaleItems)
            .ThenInclude(si => si.Medicine)
            .ToList();

        foreach (var c in customers)
        {
            Console.WriteLine($"\n👤 {c.FullName} ({c.Phone})");

            foreach (var s in c.Sales)
            {
                Console.WriteLine($"  🧾 {s.SaleDate}");
                foreach (var i in s.SaleItems)
                {
                    Console.WriteLine($"    💊 {i.Medicine.Name} | qty: {i.Quantity}");
                }
            }
        }
    }
}
