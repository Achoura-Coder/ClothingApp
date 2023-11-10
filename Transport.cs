namespace CompanyApp.Models;

public class Transport : Company
{
    public decimal Price { get; set; }


    public void NoTramway()
    {
        System.Console.WriteLine("There is no Tramway transport in this section !");
    }

}

