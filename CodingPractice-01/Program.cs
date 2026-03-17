using System;
using System.Collections.Generic;
using System.Linq;
//1
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    IEnumerable<int> result = numbers.Where(n => n > 3);

    foreach (int n in result)
    {
        Console.WriteLine(n);
    }
}
//2
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
    var result = names.Where(n => n.Contains("a"));

    foreach (var s in result)
    {
        Console.WriteLine(s);
    }
}
//3
{
    string[] names = { "Tom", "Dick", "Harry" };
    var result = names.Select(n => n.ToUpper());

    foreach (var s in result)
    {
        Console.WriteLine(s);
    }
}
//4
{
    string[] colors = { "Red", "Green", "Blue" };
    var result = colors.OrderBy(n => n);

    foreach (var color in result)
    {
        Console.WriteLine(color);
    }
}
//5
{
    int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };
    var result = numbers.OrderByDescending(n => n);
    foreach (var number in result)
    {
        Console.Write(number + " ");
    }
}
Console.WriteLine();
//6
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
    var result = names.Where(n => n.Contains("a"))
                      .OrderBy(n => n.Length)
                      .Select(n => n.ToUpper());
    foreach (var name in result)
    {
        Console.WriteLine(name);
    }
}
//7
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    var query = from n in numbers
                where n % 2 ==0
                select n;

    foreach (var n in query)
    {
        Console.WriteLine(n);
    }

}
//8
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
    var query = from n in names
                where n.Contains("a")
                orderby n.Length
                select n.ToUpper();
    foreach (var n in query)
    {
        Console.WriteLine(n);
    }
}
//9
{
    int[] numbers = { 3, 2, 1, 4, 5 };
    Console.WriteLine("메서드 구문");
    var method = numbers.Where(n => n % 2 == 1)
                        .OrderBy(n => n);

    foreach (var n in method)
    {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
    Console.WriteLine("쿼리 구문:");
    var query = from n in numbers
                where n % 2 ==1
                orderby n
                select n;
    foreach (var n in query)
    {
        Console.Write($"{n} ");
    }
}