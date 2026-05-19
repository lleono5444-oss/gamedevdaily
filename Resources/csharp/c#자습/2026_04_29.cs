using System;
using System.Xml.Linq;
using static System.Console;  // Console. 생략
using static System.Math; // Math 생략


struct Point
{
    public int X;  // public 키워드로 외부에서 int X변수를 사용하도록 설정
    public int Y;
}
class LocalFunctionAdd
{
    static void Main(string[] args)
    {
        /*  
        
        
        int add(int a, int b) => a + b;
        decimal Subtract(decimal x, decimal y) => x - y;

        Console.WriteLine($"3 + 5 = {add(3,5)}");
        Console.WriteLine($"34.56 + 12.34 = {Subtract(34.56M, 12.34M)}");
        

        foreach(string arg in args)
        {
            Console.WriteLine(arg);
        }
       
        WriteLine(Math.Pow(2, 10));

        WriteLine(Pow(2, 10));
        WriteLine(Max(3, 5));

        struct Point
        {
            public int X;
            public int Y;
        }
        Point p; //여기서 사용자 정의 데이터 형식으로써 변수를 선언할때 구조체 이름을 사용할 수 있다.
        p.X = 100;
        p.Y = 200;
        $"{p.X},{p.Y}"
        "100,200"
        
        
        //구조체를 사용하여 변수나 배열을 묶어서 관리
        Point point;
        point.X = 100;
        point.Y = 200;
        Console.WriteLine($"X : {point.X}, Y: {point.Y}");

        Product product; // 구조체 형식 변수 선언 

        product.Id = 1;
        product.Title = "좋은책";
        product.Price = 10000m;


        string message =
            $"번호 : {product.Id}\n상품명 : {product.Title}\n가격 : {product.Price}";

        Console.WriteLine(message);
        */

        BusinessCard biz;
        biz.Name = "곽기원";
        biz.Age = 17;
        Print(biz.Name, biz.Age);

        BusinessCard[] name = new BusinessCard[2];
        name[0].Name = "이세영"; name[0].Age = 102;
        name[1].Name = "권경민"; name[1].Age = 32;
        for(int i = 0; i < name.Length;i++)
        {
            Print(name[i].Name, Age[i].age);
        }






    }
    static void Print(string name, int age)
    {
        Console.WriteLine($"{name}은(는) {age}살 입니다.");
    }




}

struct Product
{
    public int Id;
    public string Title;
    public decimal Price;

}

struct BusinessCard //구조체 선언
{
    public string Name;
    public int Age;
}


