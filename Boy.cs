namespace CompanyApp.Models;

public class Boy : Garment
{
    public Boy(string categoryName, string productType) : base(categoryName, productType)
    {
        System.Console.WriteLine("Boy markets !!!");
    }

    public string Type { get; set; }

    public double Price { get; set; }

    public void StyleForMen(string type)
    {
        switch (type)
        {
            case "T-Shirt":
                Price = 5000-15000F;
                break;
            case "Shoes":
                Price = 15000-65000F;
                break;
            case "Mont":
                Price = 7000-20000F;
                break;
            default:
                Price = 0;
                break;
        }

        Type = type;
        System.Console.WriteLine("We created a section for men clothes!!!");
    }
}

