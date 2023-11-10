namespace CompanyApp.Models;

public class Design : DigitalProducts
{

    public string Type { get; set; }

    public double Price { get; set; }

    public Design(string name, string serviceName, string address, int contact)
    {
        System.Console.WriteLine("Design class constructor has been created");
    }

    public void MakeDesign(string type)
    {
        switch (type)
        {
            case "Logo":
                Price = 25000F;
                break;
            case "Poster":
                Price = 5000F;
                break;
            case "Flyer":
                Price = 15000F;
                break;
            
            default:
                throw new ArgumentException("Invalid design type");
                // Price = 0;
                // break;
        }

        Type = type;
        System.Console.WriteLine($"Design case created for type: {Type}. Price: {Price}F");
    }
}
