namespace PharmacyApp.Menus;

public class MainMenu
{
    public static void Show()
    {
        Console.WriteLine("\n--- pharmacy system ---");
        Console.WriteLine("1. add medicine");
        Console.WriteLine("2. list medicines");
        Console.WriteLine("3. sell medicine");
        Console.WriteLine("4. customers & purchases");
        Console.WriteLine("0. exit");
        Console.Write("choose: ");
    }
}
