using System;
using System.Collections.Generic;
using System.Linq;

List<Product> products = new List<Product>
{
    new Product("Laptop","Electronics", 1200),
    new Product("Mouse","Electronics",25),
    new Product("Keyboard","Electronics",75),
    new Product("Shirt","Clothing",50),
    new Product("Pants","Clothing",100),
    new Product("Desk","Furniture",250),
    new Product("Chair","Furniture",150),
    new Product("Monitor","Electronics",300),
};

Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
var price = products.Where(n => n.Price >= 100);
foreach (var n in price)
{
    Console.WriteLine(n.Name);
}
Console.WriteLine();
Console.WriteLine("문제2: Electronics 카테고리 ===");
var cate = products.Where(n => n.Categroy.Contains("Electronics"));
foreach (var n in cate)
{
    Console.WriteLine($"{n.Name} - {n.Categroy} - {n.Price}원");
}
Console.WriteLine();
Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
var name = products.OrderBy(n => n.Name);
foreach (var n in name)
{
    Console.WriteLine(n.Name);
}
Console.WriteLine();
Console.WriteLine("=== 문제4: 평균 가격 ===");
double average = products.Average(n => n.Price);
Console.WriteLine($"{average}원");

Console.WriteLine();
Console.WriteLine("=== 문제5: 가장 저렴한 상품 ===");
var min = products.OrderBy(n => n.Price).First();
Console.WriteLine($"{min.Name} - {min.Price}원");

Console.WriteLine();
Console.WriteLine("=== 문제 6: 가장 비싼 상품 ===");
var max = products.OrderByDescending(n => n.Price).First();
Console.WriteLine($"{max.Name} - {max.Price}원");

Console.WriteLine();
Console.WriteLine("=== 문제 7: Electronics 평균 가격 ===");
var elec = products.Where(n => n.Categroy.Contains("Electronics"));
double aver = elec.Average(n => n.Price);
Console.WriteLine($"{aver}원");

Console.WriteLine();
Console.WriteLine("=== 문제 8: 'o' 포함 상품(대문자) ===");
var haso = products
    .Where(n => n.Name.Contains("o"))
    .Select(n => n.Name.ToUpper());
foreach (var n in haso)
{
    Console.WriteLine(n);
}

Console.WriteLine();
Console.WriteLine("=== 문제9: Clothing 역순 ===");
var clothing = products
    .Where(n => n.Categroy.Contains("Clothing"))
    .OrderByDescending(n => n.Name);
foreach (var n in clothing)
{
    Console.WriteLine(n.Name);
}

Console.WriteLine();
Console.WriteLine("=== 문제10: 가격 50~300, 복합 정렬 ===");
var price1 = products
    .Where(n => n.Price >= 50 && n.Price <= 300)
    .OrderBy(n => n.Price)
    .ThenBy(n => n.Name);
foreach (var n in price1)
{
    Console.WriteLine($"{n.Name} - {n.Price}원");
}