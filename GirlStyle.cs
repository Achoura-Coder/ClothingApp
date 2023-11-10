namespace CompanyApp.Models;

public class GirlStyle : Garment
{
    public GirlStyle(string categoryName, string productType) : base(categoryName, productType)
    {
        System.Console.WriteLine("An instance for girls has been called...");
    }

    public string Type { get; set; }

        public double Price { get; set; }

        public void MakeWomenStyle(string type)
        {
            System.Console.WriteLine("");

            switch (type)
            {
                case "Sandal":
                    Price = 15-75000F;
                    break;
                case "Lash":
                    Price = 45-80000F;
                    break;
                case "Gez VIP":
                    Price = 35-95000F;
                    break;
    
                default:
                    Price = 0;
                    break;
            }

            Type = type;
            System.Console.WriteLine("We have created a market section for women !!!");
        }
    }


