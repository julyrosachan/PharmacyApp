using PharmacyApp.Menus;
using PharmacyApp.Services;


namespace PharmacyApp;

class Program
{
    static void Main()
    {
        var medService = new MedicineService();
        var saleService = new SaleService();

        while (true)
        {
            MainMenu.Show();
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    medService.AddMedicine();
                    break;
                case "2":
                    medService.ListMedicines();
                    break;
                case "3":
                    saleService.SellMedicine();
                    break;
                case "4":
                    saleService.ShowCustomersWithPurchases();
                    break;
                case "0":
                    return;
            }
        }
    }
}