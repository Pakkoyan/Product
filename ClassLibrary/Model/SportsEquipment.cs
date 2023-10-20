using System.Collections;

namespace Product.Model;

public abstract class SportsEquipment : Product
{
    public SportsEquipment(string name, int price, string manufacturer, int ageToBorn, string author)
    {
        Name = name;
        Price = price;
        Manufacturer = manufacturer;
        AgeToBorn = ageToBorn;
    }

    public ArrayList GetInfoBasic()
    {
        return new ArrayList()
        {
            Name,
            Price,
            Manufacturer,
            AgeToBorn
        };
    }
    
}


