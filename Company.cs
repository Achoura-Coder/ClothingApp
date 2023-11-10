namespace CompanyApp.Models;

public class Company 
{
    public string Name { get; set; }

    public string ServiceName { get; set; }

    public string Address{ get; set; }

    public int Contact { get; set;}

    public DateTime AtCreatedDate { get; set; }

    public Company(string name, string serviceName, string address, int contact) 
    : this(name, serviceName, address)
    {
        System.Console.WriteLine("");
        Contact = contact;
    }
    public Company(string Name, string ServiceName, string Address, int Contact, DateTime AtCreatedDate) 
    : this()
    {
        this.Name = Name;
        this.ServiceName = ServiceName;
        this.Address = Address;
        this.Contact = Contact;
        this.AtCreatedDate = AtCreatedDate;
      
    }

    public Company()
    {
    }

    public Company(string name, string serviceName, string address)
    {
        Name = name;
        ServiceName = serviceName;
        Address = address;
    }
}
