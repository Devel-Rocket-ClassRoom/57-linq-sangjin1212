using System;
using System.Collections.Generic;
using System.Text;
class Product
{ 
    public string Name { get; private set; }
    public string Categroy { get; private set; }
    public int Price { get; private set; }

    public Product(string name, string categroy, int price)
    {
        Name = name;
        Categroy = categroy;
        Price = price;
    }
}