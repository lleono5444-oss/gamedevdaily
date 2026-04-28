using System;

class ArrayOne4
{

    static string message = "전역 변수";


    static void Main(string[] args)
    {

        /*
        
        int[] intArray = { 1, 2, 3 }; //1차원 배열 선언,요소 생성, 초기화를 동시에,new 키워드와 int[] 생략하고 바로 초기화

        for(int i= 0;i <3; i++)
        {
            Console.WriteLine($"{i}번째의 인덱스 : {intArray[i]}");
        }


        foreach(int intValue in intArray)
        {
            Console.WriteLine("{0}",intValue);
        }

        //팀원 리스트에서 문자열 배열을 통한 자동 정렬을 사용할려면
        //함수의 매개변수화로 함수 한개를 생성,for문으로 출력;
        for (int i = 0; i < characters.Length; i++)
                {
                 Console.WriteLine(characters[i]);

                 }

       
        int[] kor = new int[3];
        int sum = 0;
        float avg = 0;

        kor[0] = 100;
        kor[1] = 90;
        kor[2] = 80;

        sum = kor[0] + kor[1] + kor[2];
        avg = sum / (float)3.0;


        Console.WriteLine($" 총점 : {sum}, 평균 : {avg: 0.00}"); // 포맷 {avg:F2}- 소수점 2자리 (추천)  ={ avg: 0.00} // 동일 효과

         
        int[] students = new int[3];
        students[0] = Convert.ToInt32(Console.ReadLine());
        students[1] = Convert.ToInt32(Console.ReadLine());
        students[2] = Convert.ToInt32(Console.ReadLine());

        //이것도 for문으로 줄일수 있을꺼 같다.

        int total = students[0] + students[1] + students[2];
        Console.WriteLine($"총점 : {total}");

        //2차원 배열 생성 및 반복문 사용
        int[,] intArray;
        intArray = new int[2, 3];

        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;


        for(int i = 0; i<2; i++)
        {
           for(int j = 0;j < 3; j++)
            {
                Console.Write($"{intArray[i, j]}_");
            }
            Console.Write("\n");
        }
       
        int[,] inArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write($"{inArray[i, j]}_");
            }
                Console.Write($"\n");

        }

        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
        for(int i = 0;i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"arr[{i},{j}] = {arr[i,j]}");
            }
        }

        int[,] arr = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if(i == j)
                {
                    arr[i, j] = 1;
                }
                else
                {
                    arr[i, j] = 0;
                }
                Console.Write(arr[i,j]);
            }

            Console.WriteLine();
        }


        //2차원 배열을 사용한 합계-평균 구하기   // 2차원 배열은 많이 쓰인다니까 연습 많이하기
        int[,] scores =
        {
            {90,100,0,0 },
            {80,90,0,0 },
            {100,80,0,0 }
        };

        for(int i = 0; i < 3; i++)
        {
            scores[i, 2] = scores[i, 0] + scores[i, 1]; //합계
            scores[i, 3] = scores[i, 2] / 2; //평균
        }
        Console.WriteLine("국어 영어 합계 평균");

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 4;j++ )
            {
                Console.Write($"{scores[i,j],4}");
            }
            Console.WriteLine();
        }

           

        //3차원 배열  --잘 안씀

        string[,,] names = new string[2, 2, 2];

        names[0, 0, 0] = "C#";
        names[0, 0, 1] = "ASP.NET";

        names[0, 1, 0] = "Windows Forms";
        names[0, 1, 1] = "WPF";

        names[1, 0, 0] = "Xamarin";
        names[1, 0, 1] = "Unity";

        names[1, 1, 0] = "UMP";
        names[1, 1, 1] = "Azure";

        Console.WriteLine("\n0층");
        Console.WriteLine($"{names[0,0,0],20}, {names[0,0,1],20}");
        Console.WriteLine($"{names[0, 1, 0],20}, {names[0, 1, 1],20}");

        Console.WriteLine("\n1층");
        Console.WriteLine($"{names[1, 0, 0],20}, {names[1, 0, 1],20}");
        Console.WriteLine($"{names[1, 1, 0],20}, {names[1, 1, 1],20}");
        

        int[,,] intArray = new int[2, 3, 4]
        {
            {{1,2,3,4},{5,6,7,8},{9,10,11,12} },
            {{13,14,15,16},{17,18,19,20},{21,22,23,24} }
        };

        for(int i = 0; i<2;i++ )
        {
            for(int j = 0; j<3;j++)
            {
                for(int k = 0; k < 4; k++)
                {
                    Console.Write("{0,2}", intArray[i, j, k]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        int[,,] arr = new int[2, 2, 2]
        {
            {{1,2},{3,4}},{{4,5},{6,7}}
        };

        Console.WriteLine("치수 출력 : {0}",arr.Rank);
        Console.WriteLine("길이 출력 : {0}",arr.Length);

        for(int i = 0; i < arr.GetLength(0);i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write("{0}\t", arr[i, j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        int[][] zagArray = new int[2][];

        zagArray[0] = new int[] { 1, 2 };
        zagArray[1] = new int[] { 3, 4,5 };
        for(int i =0; i < 2; i++)
        {
            for(int j = 0; j < zagArray[i].Length;j++)
            {
                Console.Write($"{zagArray[i][j]}\t");

            }
            Console.WriteLine();
        }
        Console.WriteLine();

        var i = 5;
        Console.WriteLine("i : {0}, 타입 : {1}",i,i.GetType());


        var s = "Hello";
        Console.WriteLine("s : {0}, 타입 : {1}", s,s.GetType());

        var numbers = new int[] { 1, 2, 3};
        foreach(var item in numbers)
        {
            Console.WriteLine("item : {0} , 타입 : {1}",item,item.GetType());
        }
        
        Show();
       
        Hi(); Hi(); Hi();
      
        ShowMessage("매개변수");
        ShowMessage("Parameter");

        string returnValue = GetString(); // 함수 호출 -- 변수 할당과 다른점은 준비된 도시락 받기와 요리해서 도시락 만드는 과정이 포함된 도시락?
        Console.WriteLine(returnValue); // 어떤 쓸모가 있을까? 채팅창에서 들어온 문자들을 한번 걸르고 싶을때 일단 반환값있는 함수로 들어오게 설정하고
        //거기서 필터링을 진행후 리턴을 받아서 출력이 되게끔 만들수 있을꺼 같다.
        //gpt왈 실무에서 이렇게 사용한다고 한다. 단 데이터의 처리에 대한 부분을 맡기고, 입력과 출력에 대한 부분들은 main함수 내에서 처리하는게 일반적
  
        int r = SquareFunction(2);
        Console.WriteLine(r);
       
        double result = Getsum(3.0, 0.14);
        Console.WriteLine(result);

        Console.WriteLine(Max(3, 5));
        Console.WriteLine(Min(-3,-5));

        int a = 3;
        int b = 5;
        int c = AddNumbers(3, 5);
        Console.WriteLine($"{a} + {b} = {c}");

        //기본 매개변수 사용
        // 메서드를 선언할때 매개변수를 선언과동시에 초기화 해 놓으면, 메서드를 호출할때 매개변수를 지정하지 않아도 기본값이 호출된다.
        Log("디버그");
        Log("에러", 4);


        /반환값이 있는것과 없는거의 차이를 분명하게 인지하자. void가 있으면 반환값이 없다는 말인데,반환값이 있을때는 그걸 받을 변수가 있어야한다는 걸 생각하면 쉽다.
        
        Sum(10, 20);
        Sum(first: 10, second: 20); // 매개변수 이름과 콜론 기호를 사용하여 호출
        Sum(second: 30, first: 40); // 매개변수 이름을 지정하면 , 변수 위치를 변경해서 호출 가능

        /메서드 오버로드 들어오는 변수 타입에 따른 해당 함수 자동호출 가능
        GetNumber(1234);
        GetNumber(1234L);

        //들어온 변수가 없으면 기본값 호출, 들어오는 값있으면 해당 함수 호출
        hello();
        hello("반갑습니다");

        Multi();
        Multi("반갑습니다");
        Multi("인내하자",3);

        Console.WriteLine(4 * 3 * 2 * 1);
        Console.WriteLine(FactorialFor(4));
        Console.WriteLine(Factorial(4));
        Console.WriteLine(Fact(4));

         
        Console.WriteLine(myPower(2, 10));

       
        ShowMessage();
        Console.WriteLine(message);

        Hi();
        MultiPly(3, 5);
       
        Log("함수 축약");
        Console.WriteLine(IsSame("A","B"));
         

        void Display(string text)
        {
            Console.WriteLine(text);
        }
        Display("로컬 함수");

         */











    }

    static void Log(string message) => Console.WriteLine(message);
    static bool IsSame(string a, string b) => a == b;





    static void Show()    //  일반적으로 함수에서는 함수를 호출하기에 코드가 앞에 위치해야하지만 C#에서는 앞뒤 상관없다.
    {
        Console.WriteLine("Hello,World!");
    }

    /*static void Hi()   // void는 반환값이 없는 함수를 지정할때 사용한다.
    {
        Console.WriteLine("안녕하세요");
    }
    */
    static void ShowMessage(string message)
    {
        Console.WriteLine(message);

    }
    static string GetString()
    {
        return "반환값(Return Value)";
    }

    static int SquareFunction(int x)
    {
        int r = x * x;
        return r;
    }

    static double Getsum(double x, double y)
    {
        double r = x + y;
        return r; //  들어온 변수값이 나가는게 아니라 나갈 변수를 지정해서 나갈수 있음을 인지하자
    }

    static int Max(int x, int y)
    {
        return (x > y) ? x : y;  //조건 ? 참일때 값 : 거짓일때 값 --x가 y보다 크면 x 반환, 아니면 y 반환
    }

    static int Min(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }


    ///<summary>
    ///두 수를 더하여 그 결과값을 반환시켜 주는  함수
    ///</summary>
    ///<param name="a">첫 번째 매개변수</param>
    ///<param name="b">두 번째 매개변수</param>
    ///<returns>a+b 결과</returns>
    ///

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }


    static void Log(string message, byte level = 1) // byte int short long
    {
        Console.WriteLine($"{message}, {level}");
    }

    static void Sum(int first, int second)
    {
        Console.WriteLine((first + second));
    }

    static void GetNumber(int number)
    {
        Console.WriteLine($"Int32 : {number}");
    }
    static void GetNumber(long number)
    {
        Console.WriteLine($"Int64 : {number}");
    }

    static void hello()
    {
        Console.WriteLine("안녕하세요");
    }
    static void hello(string msg)
    {
        Console.WriteLine(msg);
    }

    static void Multi()
    {
        Console.WriteLine("안녕하세요");
    }
    static void Multi(string message)
    {
        Console.WriteLine(message);
    }
    static void Multi(string message,int count)
    {
        for(int i =0; i < count; i++)
        {
            Console.WriteLine("{0}",message);
        }
    }

    static int Fact(int n)
    {
        return ((n > 1) ? n * Fact(n - 1) : 1) ;
    }

    static int Factorial(int n)
    {
        if(n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    
    static int FactorialFor(int n)
    {
        int result = 1;
        for(int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;

    }

    static int myPower(int num, int cnt)
    {
        if(cnt == 0)
        {
            return 1;
        }
        return num * myPower(num, --cnt);
    }

    static void ShowMessage()
    {
        string message = "지역 변수";
        Console.WriteLine(message);
    }

    static void Hi() => Console.WriteLine("안녕하세요");
    static void MultiPly(int a, int b) => Console.WriteLine(a * b);

}



