using CompanyApp.Models;

Company company1 = new Company();

company1.Name = "Achoura Mall";
company1.ServiceName = "Commerce and Marketing";
company1.Address = "Maradi-Niger";
company1.Contact = 98649076;


System.Console.WriteLine(company1.AtCreatedDate);

Company company2 = new Company("May's shop", "Transit", "Niamey", 96016974);
System.Console.WriteLine(company2.AtCreatedDate);

Company company3 = new Company()
{
    Name = "Atou Mall",
    ServiceName = "Beauty Shop",
    Address = "Diaspora City",
    Contact = 80475045
};

System.Console.WriteLine(company3);

DigitalProducts digitProducts = new DigitalProducts();
digitProducts.ProductName = "Website-Design";
digitProducts.CategoryName = "Visual communication";
digitProducts.Price = 450.5;

System.Console.WriteLine(digitProducts);

Website website1 = new Website("Siteweb", "Conception", "Maradi", 96777779);

website1.CreateWeb("simple");

Design design_1 = new Design("Adax", "Graphisme", "Niamey", 96626226);
design_1.Type = "Poster";
design_1.Price = 10000F;
Console.WriteLine($"Design Type: {design_1.Type}, Price: {design_1.Price}F");

// System.Console.WriteLine(design_1);

Design design2 = new Design("Kalla Transa", "Trading", "Niger", 80252550);
design2.Type = "Flyer";
design2.Price = 15000F;
Console.WriteLine($"Design Type: {design2.Type}, Price: {design2.Price}F");

// design2.MakeDesign("Flyer");

Transport transport1 = new Transport()
{
    Price = 25000,
};
System.Console.WriteLine(transport1);

Garment garment = new Garment("SKDProduction", "Lights", "Maradi", 88786708);
garment.ProductType = "CLothes";
garment.CategoryName = "Style";

System.Console.WriteLine(garment);

Boy swaggers = new Boy("Style", "CLothes");
swaggers.Type = "Shoes";
swaggers.Price = 35000F;

System.Console.WriteLine($"Boy Type : {swaggers.Type}, Price: {swaggers.Price}F");

GirlStyle Lady = new GirlStyle("Beauty", "Lips")
{
    Type = "Sandal",
    Price = 55000
};