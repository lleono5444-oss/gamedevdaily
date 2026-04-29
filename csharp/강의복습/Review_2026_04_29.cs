using System;

class Progrom
{
    /*
     * 1.Console.WriteLine($"이름 : {info.Name}"); 변수.하위요소로 하위요소 출력가능
     * 2. studentInfo studentA = new studentInfo("곽기원", 2000, -0.1f); 사용자 정의 자료형 ;사용자정의 데이터형식
     * 2.1 사용자 정의 자료형은 여러 데이터를 하나로 묶는 타입을 의미한다. 위에서는 studentInfor가 이에 해당한다.
     * 3. struct 는 데이터(필드) + 그 데이터를 다루는 규칙(생성자, 메서드)을 묶은 타입
     * 3.1 (데이터(필드) + 생성자 + 동작(메서드 등) 을 담을 수 있는 타입이다)- 동적인 부분은 나중에 배울꺼 같다.
     * 3.2 struct도 class와 같은 타입 형식이다.하지만  당연하게 class 내에서 선언된 struct는 다른 class나 타입에서 호출을 조건부 가능하다.
     * 3.3 변수와 다른 점은 변수는 절차를 진행후 사라지지만 struct는 접근 제한이 걸려있을뿐이다
     * 3.4 그럼 어떻게 접근이 가능하냐? 1.접근 제한자를 public 등으로 바꾸기 +  내부타입일 경우 소속된 타입 이름을 붙여야 접근가능 ex) Program.studentInfo s; 2.같은 범위 안에 두기 
     * 3.5 기본적으로 메서드,필드,내부 struct/class는 private가 기본 접근제한자로 설정되어있다
     * 3.5.1 struct가 private이라 외부에서는 접근이 막히지만,같은 클래스 내부에서는 struct 접근이 가능하기 때문에 그 안의 public 멤버도 사용할 수 있다
     * 4. 생성자는 struct가 생성될 때 데이터를 어떻게 초기화할지 정하는 규칙이다.
     * 4.1.생성자는 struct 내에서만 존재해야한다.
     * - 내부타입 : 다른 타입(class/struct) “안에 정의된 타입”
     * class 타입 밑에 같은 내부에서는 public이 없어도 접근이 가능한 걸로 알고 있는데 해당 코드는 public을 안붙이면 실행이 안된다.
     * 답변: 같은 클래스 내에서 안에 소속된 타입이나 타입들을 서로에 대해 파악은 가능한 상태이다. 아무리 그게 private로 걸려있어도. 단, 그 타입과 메서드 내부의 변수를 확인하는 것은 안되는데, 그게 private라는 
     * 상자로 한꺼풀 더 감싸져 있기 때문이다. 따라서 해당 변수를 같은 클래스 내에서 다른 타입이나 메서드가 호출할려면 그게 public이 걸려 있어야하는 것이다.
    */

    static void Main()
    {
        studentInfo studentA = new studentInfo("곽기원", 2000, -0.1f);
        PrintProfile(studentA);
        Variable();
        Operators();
    }

    static void PrintProfile(studentInfo info)
    {
        Console.WriteLine($"이름 : {info.Name}");
        Console.WriteLine($"생년월일 : {info.BirthYear}");
        Console.WriteLine($"이름 : {info.EyeSight}");
    }

    private struct studentInfo
    {
        public string Name;
        public int BirthYear;
        public float EyeSight;

        studentInfo(string name, int birthYear, float eyeSight)
        {
            Name = name;
            BirthYear = birthYear;
            EyeSight = eyeSight;
        }

    }


    static void Variable()
    {

        int myMoney; //변수의 선언
        myMoney = 100; //변수의 할당

        // " = " 할당을 하겠다 라는 표현입니다.(<=할당 연산자=대입연산자)

        //변수=데이터를 담는 그릇(공간)
        //컴파일러에게 변수를 알려주고 싶을때는 공간,네이밍,자료형을 알려줘야합니다.
        Console.WriteLine(myMoney);

        int myNEWMoney = 1000; // 변수의 초기화  -- 상황에 따라 초기화와 선언&할당을 취사선택해야한다
        Console.WriteLine(myNEWMoney);

        myMoney = myMoney + myNEWMoney; // 변수의 재할당
        Console.WriteLine(myMoney);

        float pie = 3.14f;
        string myName = "곽기원";
        Console.WriteLine($"pie = {pie}, myName = {myName}");


    }
    static void DataType()
    {
        /* 변수에 사용할수 있는 기본자료형
         1.정수형 = int, byte(lone,short)-- int = 4byte=2의 32승 , byte = 2의 8승
         2.실수 = float, (double) --
         2.1. 실수 표현 은 마지막 2bit에서 자릿수에 대한 자리로 할당한다.
         3.논리형 = bool =>true,false | (참,거짓)
         4.문자형 = char,
         5.문자열 = string
        */

    }

    static void Operators()
    {
        //연산자 (Operators)
        //컴퓨터가 연산을 수행하도록 지시하는 특별한 기호
        //변수들을 사용해서 데이터를 처리하고 조작하는데 사용됩니다


        //산술연산자 ( +, - ,* ,/ , %)
        int number = 100;
        Console.WriteLine($"덧셈 : {number + 50}");
        Console.WriteLine($"뺄셈 : {number - 50}");
        Console.WriteLine($"곱셈 : {number * 50}");
        Console.WriteLine($"나눗셈 : {number / 50}");
        Console.WriteLine($"나머지 : {number % 50}");

        //할당(대입)연산자( = )
        //비교연산자
        //참, 거짓 형태로 연산 결과를 반환 합니다.
        //<,>< >=,<=,==,!=

        number = 500;   // number에 새로운 수를 재할당 합니다.
        bool isBigger = number > 100;
        Console.WriteLine($"number > 100; : {isBigger}");

        isBigger = number > 1000;
        Console.WriteLine($"number > 100; : {isBigger}");

        bool isSame = number == 250;
        Console.WriteLine($"number == 250 : {isSame}");
        isSame = number == 500;
        Console.WriteLine($"number == 250 : {isSame}");

        int numberA = 100;
        int numberB = 100;
        int numberC = 150;

        bool isBiarggerOrEpual = numberA >= numberB;
        Console.WriteLine($"numberA >= numberB : {isBiarggerOrEpual}");

        isBiarggerOrEpual = numberC >= numberA;
        Console.WriteLine($"numberC >= numberA : {isBiarggerOrEpual}");
        isBiarggerOrEpual = numberC <= numberA;
        Console.WriteLine($"numberC <= numberA : {isBiarggerOrEpual}");
        bool isDiffrent = numberB != numberA;
        Console.WriteLine($"numberB != numberA : {isDiffrent}");
        isDiffrent = numberC != numberA;
        Console.WriteLine($"numberC != numberA : {isDiffrent}");

        //논리 연산자
        //&&(And) => 좌우 true일떄만 true반환, ||(Or) => 좌항과 우항 중 하나만 true여도 true 반환

        int a = 10;
        int b = 20;
        int c = 15;

        bool andResult = (a < c) && (c < b); //c가 a와 b사이에 있는가
        bool orResult = (c < a) || (b < c); //c가 a보다 작거나 b보다 큰가

        Console.WriteLine($"andResult = {andResult}");
        Console.WriteLine($"orResult = {orResult}");

        //증감 연산자

        //삼항 연산자(나중에)

    }

}