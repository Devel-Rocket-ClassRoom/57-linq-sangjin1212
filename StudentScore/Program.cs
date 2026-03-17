using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using System.Xml;

List<Student> students = new List<Student>
{
    new Student("김철수","수학",85),
    new Student("김철수","영어",78),
    new Student("이영희","수학",92),
    new Student("이영희","영어",88),
    new Student("박민수","수학",76),
    new Student("박민수","영어",82),
    new Student("정지은","수학",95),
    new Student("정지은","영어",91)
};
Console.WriteLine("=== 문제 1: 85점 이상 ===");
var socre = students.Where(n => n.Score >= 85);
foreach (var n in socre)
{ 
    Console.WriteLine($"{n.Name} - {n.Subject}: {n.Score}점");
}
Console.WriteLine();

Console.WriteLine("=== 문제2: 수학 과목 ===");
var math = students.Where(n => n.Subject.Contains("수학"));
foreach (var n in math)
{
    Console.WriteLine($"{n.Name} - {n.Subject}: {n.Score}점");
}
Console.WriteLine();

Console.WriteLine("=== 문제3: 점수 내림차순 ===");
var descending = students.OrderByDescending(n => n.Score);
foreach (var n in descending)
{
    Console.WriteLine($"{n.Name} - {n.Subject}: {n.Score}점");
}
Console.WriteLine();

Console.WriteLine("=== 문제 4: 전체 평균 ===");
double average = students.Average(n => n.Score);
Console.WriteLine($"{average}점");
Console.WriteLine();

Console.WriteLine("=== 문제 5: 수학 최고/죄저 점수 ===");
var mathMaxMin = students.Where(n => n.Subject.Contains("수학"));
var mathMax = mathMaxMin.Max(n => n.Score);
var mathMin = mathMaxMin.Min(n => n.Score);
Console.WriteLine($"최고: {mathMax}");
Console.WriteLine($"최저: {mathMin}");
Console.WriteLine();

Console.WriteLine("=== 문제 6: 영어 90점 이상 존재 여부 ===");
var Eng = students.Where(n => n.Subject.Contains("영어"));
bool has = Eng.Any(n=> n.Score >= 90);
Console.WriteLine(has);
Console.WriteLine();

Console.WriteLine("=== 문제 7: 모두 70점 이상 여부 ===");
bool all = students.All(n => n.Score >= 70);
Console.WriteLine(all);
Console.WriteLine();

Console.WriteLine("=== 문제 8: 학생 이름 (중복 제거) ===");
var distinct = students.DistinctBy(n => n.Name);
foreach (var n in distinct)
{
    Console.WriteLine(n.Name);
}
Console.WriteLine();

Console.WriteLine("=== 문제 9: 수학 최고점 학생 ===");
var mathHigh = students.Where(n => n.Subject.Contains("수학"))
    .OrderByDescending(n => n.Score);
var student = mathHigh.First();
Console.WriteLine(student.Name);
Console.WriteLine();

Console.WriteLine("=== 문제 10; 과목별 정렬 ===");
var subject = students.OrderBy(n => n.Subject == "수학" ? 0 : 1)
    .ThenBy(n => n.Name);
foreach (var n in subject)
{
    Console.WriteLine($"{n.Name} - {n.Subject}: {n.Score}점");
}
