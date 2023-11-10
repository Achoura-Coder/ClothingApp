namespace CompanyApp.Models;

public class Website : DigitalProducts
{

    public string Type { get; set; }

    public double Price { get; set; }


    public Website(string Name, string ServiceName, string Address, int Contact) : base(Name, ServiceName, Address, Contact)
    {
        System.Console.WriteLine("Instance with 4 parameters...");
    }

    // Méthode pour créer un site web
    public void CreateWeb(string type)
    {
        // Selon le type choisi, on attribue un prix différent
        switch (type)
        {
            case "Simple":
                Price = 250000F;
                break;
            case "E-commerce":
                Price = 500000F;
                break;
            case "Blog":
                Price = 150000F;
                break;
            default:
                Price = 0;
                break;
        }

        Type = type;
        // On affiche les informations du site web créé
        Console.WriteLine("Vous avez créé un site web de type {0} pour le prix de {1}F", Type, Price);
    }
}

