namespace CompanyApp.Models;

public class Garment : Company
{
    public string ProductType { get; set; }
    public string CategoryName { get; set; }

    public Garment(string categoryName, string productType)
    {
        CategoryName = categoryName;
        ProductType = productType;
    }

    public Garment(string name, string serviceName, string address, int contact) : base(name, serviceName, address, contact)
    {
        System.Console.WriteLine("");
    }
}

