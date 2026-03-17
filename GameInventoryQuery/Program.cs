using System;
using System.Collections.Generic;
using System.Linq;

List<GameItem> items = new List<GameItem>
{
    new GameItem("나무 검","무기","일반",100,3),
    new GameItem("강철 대검","무기","희귀",800,1),
    new GameItem("용의 검","무기","전설",5000,1),
    new GameItem("가죽 갑옷","방어구","일반",200,2),
    new GameItem("미스릴 갑옷","방어구","희귀",1200,1),
    new GameItem("드래곤 갑옷","방어구","전설",8000,0),
    new GameItem("체력 물약","소비","일반",50,10),
    new GameItem("마나 물약","소비","일반",80,5),
    new GameItem("고급 물약","소비","희귀",500,0),
    new GameItem("엘릭서","소비","전설",3000,2),
};

Console.WriteLine("=== 쿼리1: 가격이 500이상 (가격 내림차순) ===");
var price = from n in items
                  where n.Price >= 500
                  orderby n.Price descending
                  select n;
foreach (var n in price)
{ 
    Console.WriteLine($"{n.Name} - {n.Type} - {n.Price}원");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리2: 무기 타입 (등급순) ===");
var type = from n in items
           where n.Type.Contains("무기")
           orderby n.Grade == "일반" ? 0 :
                   n.Grade == "희귀" ? 1 : 2
           select n;
foreach (var n in type)
{
    Console.WriteLine($"{n.Name} - {n.Grade} - {n.Price}");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리3: 총 가치 1000 이상 ===");
var let = from n in items
          let totalprice = n.Price * n.Quantity
          where totalprice >= 1000
          select new { n.Name, totalprice };
foreach (var n in let)
{
    Console.WriteLine($"{n.Name} - 총 가치: {n.totalprice}");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순) ===");
var soldout  = from n in items
               where n.Quantity == 0
               orderby n.Name
               select n;
foreach (var n in soldout)
{
    Console.WriteLine($"{n.Name}");
}
Console.WriteLine();
Console.WriteLine("=== 쿼리 5: 전설 등급 (이름과 가격) ===");
var item = from n in items
           where n.Grade.Contains("전설")
           select new { n.Name,n.Price };
foreach (var n in item)
{
    Console.WriteLine($"{n.Name} - {n.Price}");
}