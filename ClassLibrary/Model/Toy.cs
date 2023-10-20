using System.Collections;

namespace Product.Model;

public abstract class Toy : Product
{
    public string Material { get; set; }

    public Toy(string name, int price, string manufacturer, int ageToBorn, string material)
    {
        Name = name;
        Price = price;
        Manufacturer = manufacturer;
        AgeToBorn = ageToBorn;
        Material = material;
    }
    
    public ArrayList GetInfoBasic()
    {
        return new ArrayList()
        {
            Name,
            Price,
            Manufacturer,
            AgeToBorn,
            Material
        };
    }
    
}
