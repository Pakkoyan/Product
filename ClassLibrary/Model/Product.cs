using System.Collections;

namespace Product.Model;

public abstract class Product
{
    public abstract string Name { get; set; }
    public abstract int Price { get; set; }
    public abstract string Manufacturer { get; set; }
    public abstract int AgeToBorn { get; set; }

    public abstract ArrayList GetInfo();

}


