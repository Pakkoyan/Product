using System.Collections;

namespace Product.Model;

public abstract class Book : Product
{
    public string Author { get; set; }

    public Book(string name, int price, string manufacturer, int ageToBorn, string author)
    {
        Name = name;
        Price = price;
        Manufacturer = manufacturer;
        AgeToBorn = ageToBorn;
        Author = author;
    }
    
    public ArrayList GetInfoBasic()
    {
        return new ArrayList()
        {
            Name,
            Price,
            Manufacturer,
            AgeToBorn,
            Author,
        };
    }
}
