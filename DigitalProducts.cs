namespace CompanyApp.Models;

public class DigitalProducts : Company
{
    public DigitalProducts()
    {
        System.Console.WriteLine("DIgitalProducts instance has been created from DigitalProducts class");
    }
    public string ProductName { get; set; }

    public string CategoryName { get; set; }

    public double Price { get; set; }


    public DigitalProducts(string Name, string ServiceName, string Address, int Contact)
    : base(Name, ServiceName, Address, Contact)
    {
        System.Console.WriteLine("We've created an Instance with 4 parameters...");
    }

    
}
