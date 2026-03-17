using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
//1
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    int sum = numbers.Sum();
    int count = numbers.Count();
    double average = numbers.Average();
    Console.WriteLine($"합계: {sum}");
    Console.WriteLine($"개수: {count}");
    Console.WriteLine($"평균: {average}");
}
//2
{
    int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };

    int min = numbers.Min();
    int max = numbers.Max();

    Console.WriteLine($"최솟값: {min}");
    Console.WriteLine($"최댓값: {max}");
}
//3
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int sum = numbers.Where(n => n % 2 == 0).Sum();
    int over = numbers.Count(n => n > 5);

    Console.WriteLine($"짝수 합계: {sum}");
    Console.WriteLine($"5보다 큰 숫자 갯수: {over}");
}
//4
{
    int[] numbers = { 10, 20, 30, 40, 50 };

    int first = numbers.First();
    int last = numbers.Last();

    Console.WriteLine($"첫 번째: {first}");
    Console.WriteLine($"마지막: {last}");
}
//5
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    int first = numbers.First(n => n > 3);
    Console.WriteLine($"3보다 큰 첫 번쨰: {first}");
}
//6
{
    int[] numbers = { 10, 20, 30, 40, 50 };

    var take = numbers.Take(3);
    var skip = numbers.Skip(2);

    Console.WriteLine("처음 3개:");
    foreach (int n in take)
    {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
    Console.WriteLine("2개 건너뛴 후:");
    foreach (int n in skip)
    {
        Console.Write($"{n} ");
    }
 
}
Console.WriteLine();
//7
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    bool any = numbers.Any();
    bool anyeven = numbers.Any(n => n % 2 == 0);
    bool all = numbers.All(n => n > 0);

    Console.WriteLine($"요소 존재: {any}");
    Console.WriteLine($"짝수 존재: {anyeven}");
    Console.WriteLine($"모두 양수: {all}");
}

//8
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    bool has3 = numbers.Contains(3);
    bool has10 = numbers.Contains(10);

    Console.WriteLine($"3 포함: {has3}");
    Console.WriteLine($"10 포함: {has10}");
}
//9
{
    int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 5 };
    var number = numbers.Distinct();

    foreach (int n in number)
    {
        Console.Write($"{n} ");
    }
}
Console.WriteLine();

//10
{
    int[] first = { 1, 2, 3 };
    int[] second = { 3, 4, 5 };

    var concat = first.Concat(second);
    var union = first.Union(second);

    Console.WriteLine("Concat:");
    foreach (int n in concat)
    {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
    Console.WriteLine("Union:");
    foreach (int n in union)
    {
        Console.Write($"{n} ");
    }
}
Console.WriteLine();
//11
{
    var numbers = new List<int> { 1, 2, 3};

    var number = numbers.Where(n => n > 1);
    numbers.Add(4);
    Console.WriteLine("결과:");
    foreach (int n in number)
    {
        Console.WriteLine(n);
    }
}
//12
{
    var numbers = new List<int> { 1, 2, 3 };
    int count = numbers.Count();
    numbers.Add(4);

    Console.WriteLine($"개수: {count}");
}
//13
{
    var numbers = new List<int> { 1, 2, 3 };
    var result = numbers.Where(n => n > 1).ToList();
    numbers.Add(4);
    Console.WriteLine("결과:");
    foreach (int n in result)
    {
        Console.WriteLine(n);
    }
}
//14
{
    var names = new List<string> { "홍길동", "김철수", "이영희" };

    var result = names.Select(n => new { Name = n, Langth = n.Length });

    foreach (var n in result)
    {
        Console.WriteLine($"이름: {n.Name}, 길이: {n.Langth}");
    }
}

//15
{
    string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

    int count = (from n in names
                 where n.Contains("a")
                 select n).Count();
    Console.WriteLine($"'a' 포함 이름 개수: {count}");
    string first = (from n in names
                    orderby n
                    select n).First();

    Console.WriteLine($"알파벳 순 첫 번째: {first}");

}