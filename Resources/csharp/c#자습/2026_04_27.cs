using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

class If
{
    static void Main(string[] args)
    {

        /*
        //평균 점수 계산 프로그램
        int kor = 100;
        int eng = 90;

        int tot = 0;
        double avg = 0.0;

        tot = kor + eng;
        avg = tot / 2.0;


        Console.WriteLine("총점 : {0}", tot);
        Console.WriteLine("평균 : {0:F1}", avg);  // F1 : 소수점 1자리까지 출력


        // if 문으로 조건 처리
        int score = 60;

        if (score >= 60)
        {
            Console.WriteLine("합격");
        }


        //if문과 비교 연산자 사용
        int x = 10;

        if (x == 10)
        {
            Console.WriteLine($"x는 {x}입니다.");
        }

        if (x != 20)
        {
            Console.WriteLine($"x는 20이 아닙니다.");
        }

        //중첩 if

        string name = "C#";
        int version = 8;

        if (name == "C#")
        {
            if (version == 8)
            {
                Console.WriteLine($"{name}, {version}.");
            }
        }


        //두 조건 처리
        int score1 = 59;

        if (score1 >= 60)
        {
            Console.WriteLine("합격");
        }
        else
        {
            Console.WriteLine("불합격");
        }

        //두 수에서 큰수 처리

        Console.Write("첫번쨰 수");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("두번쨰 수\n");
        int second = Convert.ToInt32(Console.ReadLine());

        if (first >= second)
        {
            Console.WriteLine("큰 값 : {0}",first);
        }
        else
        {
            Console.WriteLine("큰 값 : {0}",second);
        }


        //대 소문자 구분
        Console.WriteLine("영문 대문자 또는 소문자 하나를 입력하세요.");
        char c = Convert.ToChar(Console.ReadLine());

        if (c >= 'A' && c <= 'Z') // A~Z, a~z 이 구분을 인지하자
        {
            Console.WriteLine($"{c}는 대문자입니다.");
        }
        else
        {
            Console.WriteLine($"{c}는 소문자입니다.");
        }
        
        //입력 받은 문자에 따른 반환값 처리
        Console.Write("문자를 입력하세요. (y/n/c) :");
        Char input = Convert.ToChar(Console.ReadLine());

        if(input == 'y')
        {
            Console.WriteLine("예");
        }
        else
        {
            if (input == 'n')
            {
                Console.WriteLine("아니요");
            }
            if (input == 'c')
            {
                Console.WriteLine("취소합니다");
            }
        }
        /*변수 선언은 한번만 하고 그 변수값 초기화는 가능하다는걸 인지하자 ex)int score = 
         * 10은 한번만 선언하고, 뒤에서 score =20처럼 값 초기화만 가능하다는걸 인지하자.변수 선언은 한번만 
        

        
        //입력받은 점수에 따른 상장 수여
        Console.Write("점수 : ");
        int score = Convert.ToInt32(Console.ReadLine());
        string grade = "";
       
        if(score >= 90)
        {
            grade = "금상";
        }
        else
        {
            if(score >= 80)
            {
                grade = "은상";
            }
            else
            {
                if(score >= 70)
                {
                    grade = "동상";
                }
                else
                {
                    grade = "노메달";
                }

            }
        }

        Console.WriteLine($"{grade}을 수상하셨습니다");


        // if ~else if ~ else 구문에서 else if 구문은 여러 개 사용할 수 있지만,조건식이 위부터 내림차식으로 범위를 설정해야하며, 빈 부분이 없어야한다.
         
         
         

        //양,음수,0 판별 프로그램
        int number = -10;

        if (number > 0)
        {
            Console.WriteLine($"{number}은 양수입니다");
        }
        else if (number < 0) 
        {
            Console.WriteLine($"{number}은 음수입니다");
        }
        else
        {
            Console.WriteLine($"{number}은 0입니다.");
        }

       
      


        //점수에 따른 학점 처리 프로그램
       

        int score = 0;
        char grade = 'F';

        Console.WriteLine("당신의 점수는?");
        score = Convert.ToInt32(Console.ReadLine());


        if(score >=90)
        {
            grade = 'A';
        }
        else if(score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        Console.WriteLine($"점수 : {score}점");
        Console.WriteLine($"학점 : {grade}학점");

        

        Console.Write("정수 입력 : _\b");   // 쓸 자리 밑에 밑줄 그어지게 하고, 입력시 덮어씌워지면서 자동으로 밑줄은 사라짐
        int a = Convert.ToInt32(Console.ReadLine());

        //if 문은 주로 데이터의 필터링 역할을 한다.
        // if문 사용
        if(a % 2 == 0)
        {
            Console.WriteLine("짝수");
        }

        //if ~ else문 사용
        if (a % 2 != 0)
        {
            Console.WriteLine("홀수");
        }
        else
        {
            Console.WriteLine("짝수");

        }

        //if ~ else if ~ else문 사용

        if (a % 3 == 0)
        {
            Console.WriteLine("3의 배수");
        }
        else if(a % 5 == 0)
        {
            Console.WriteLine("5의 배수");
        }
        else if (a % 7 == 0)
        {
            Console.WriteLine("7의 배수");
        }
        else
        {
            Console.WriteLine("3,5,7의 배수가 아닙니다.");
        }


        //문자열의 int변환 가능 여부 판별 프로그램
        string data = "1234";
        int result;

        if(int.TryParse(data,out result))
        {
            Console.WriteLine("변환가능 : {0}", result);
        }
        else
        {
            Console.WriteLine("변환 불가");
        }

        //문자열의 double변환 가능 여부 판별 프로그램
        double d;
        if(double.TryParse(data,out d))
        {
            Console.WriteLine("변환가능 : {0}", d);
        }    

        //변수 선언을 if 문 내에서도 가능하다.

    if(double.TryParse("3.14",out var r)) //  Parse는 무조건 변환이고 변환은 못할시 예외 발생, TryParse는 변환이 가능한지 여부를 반환하는 메서드
        {
            Console.WriteLine($"{r} {r.GetType()}");  // r.GetType() : r의 데이터 타입을 반환하는 메서드
        }
        else
        {
            Console.WriteLine("변환 불가");
        }


        //if문은 범위,여러 조건 결합(&&,||),복잡한 로직에 주로 사용하고, switch문은 특정 값과 정확히 일치, 케이스가 많을때 가독성이 좋다는 특징이 있다.

        int x = 2;

        switch (x)      //switch문은case와 default로 구성되어있으며, case는 특정 값과 일치할 때 실행되는 코드 블록을 정의하는 키워드이고, default는 모든 case에 해당하지 않을 때 실행되는 코드 블록을 정의하는 키워드이다.default 레이블은 생략 가능하다.
        {
            case 1:
                Console.WriteLine("1입니다.");
                break;
            case 2:
                Console.WriteLine("2입니다.");
                break;
        }

        //입력 값에 따른 출력
        Console.WriteLine("정수를 입력하세요.");
        int answer = Convert.ToInt32(Console.ReadLine());

        switch(answer)
        {
            case 1:
                Console.WriteLine("1을 선택했습니다");
                break;
            case 2:
                Console.WriteLine("2을 선택했습니다");
                break;
            case 3:
                Console.WriteLine("3을 선택했습니다");
                break;
            default:
                Console.WriteLine("그냥 찍으셨군요.");
                break;
        }

        //switch 문을 사용한 프로그램
        Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
        Console.Write("1.C\t");    //\t : 탭 간격을 띄어주는 이스케이프 시퀀스
        Console.Write("2.C++\t");
        Console.Write("3.C#\t");
        Console.Write("4.Java\t");
        Console.Write("5.그 외\t");
        int coice = Convert.ToInt32(Console.ReadLine());

        switch(coice)
        {
            case 1:
                Console.WriteLine("C 선택");
                break;
            case 2:
                Console.WriteLine("C++ 선택");
                break;
            case 3:
                Console.WriteLine("C# 선택");
                break;
            case 4:
                Console.WriteLine("Java 선택");
                break;
            default:
                Console.WriteLine("C,C++,C#,Java가 아니군요.");
                break;
        }

        
        //날씨 묻기  -- swith문은 문자열도 받을 수 있다.
        Console.WriteLine("오늘 날씨는 어떤가요? (맑음,흐림,비,눈,...)");
        string weather = Console.ReadLine();

        switch(weather)
        {
            case "맑음":
                Console.WriteLine("오늘은 맑은 날씨입니다.");
                break;
            case "흐림":
                Console.WriteLine("오늘 날씨는 흐리군요.");
                break;
            case "비":
                Console.WriteLine("오늘 날씨는 비가 내리는군요.");
                break;
            default:
                Console.WriteLine("혹시 눈이 내리나요?.");
                break;
        }

        

        //for(초기식;조건식;증감식) {실행문;}  -- for문은 반복 횟수가 명확할 때 주로 사용한다

        for (int i = 0 ; i<3 ; i++)
        {
            Console.WriteLine("안녕하세요!");
        }


       
        //1~5출력 for문

        for (int i = 1 ; i <= 5; i++)
        {
            Console.WriteLine("Count : {0}", i);
        }

        
        //0부터 4까지 2씩 증가하는 for문

        for(int i=0; i< 5; i += 2)
        {
            Console.WriteLine(i);
        }

        */

        //1~3까지 반복 합산
        /*for문 내부선언과 외부선언의 차이 
         * 
         *for문 내부는 안전성이 높지만 for문이 종료 되면 재사용이 불가능하다.
         *그에 반해 외부는 안전성이 낮지만, 종료 이후에도 재사용이 가능하다.
         *기본적으로는 for안에서 선언하고 필요할때만 밖으로 뺸다. 
        int n = 3;
        int sum = 0;
        for(int i =1;i <=n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"1부터{n}까지의 합 : {sum}");

        

        int n = 5;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine($"1부터 {n}까지 짝수의 합 : {sum}");

        

        //1부터 100까지 정수의 합 구하기

        int sum = 0;

        for(int i = 1; i <=100; i++)
        {
                sum += i;
        }

        Console.WriteLine($"1부터 100까지 정수의 합 : {sum}"); 

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("{0}\t",i);    // Write와 WriteLine 헷갈리지말자. 줄바꿈 x / o
            if(i % 3 == 0)
            {
                Console.WriteLine();     //3의 배수에서 줄바꿈 
            }

        }
        Console.WriteLine();   //줄바꿈


        int sum1 = 0;

        for( int i = 1; i <= 100; i++) // 1부터 100까지 정수 더하기
        {
            sum1 += i;

        }

        Console.WriteLine($"1부터 100까지의 합 : {sum1}");


        //1부터 100까지 짝수의 합 구하기
        int sum2 = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sum2 += i;
            }
        }

        Console.WriteLine($"1부터 100까지 짝수의 합 : {sum2}");

        
        // 삼각형 만들기

        for(int i = 1; i <= 5; i++)
        {
            for  (int j = 1; j <= i; j++)  
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //무한 루프
        for (; ; )
        {
            Console.WriteLine("무한루프");
        }

        int fact = 0;

        for(int i = 1; i < 5; i++)
        {

            Console.Write($"{i}! -> ");
            fact = 1;   //1로 초기화
            
            for(int j = 1; j <= i; j++)  //1부터 4까지 곱하기
            {
                fact *= j;
            }

            Console.WriteLine($"{fact,2}"); // 펙토리얼로 한개씩 출력후 줄바꿈 //{fact,2} : fact를 2자리로 출력하라는 의미,출력값끼리 정렬할려고 사용
        }

        // 구구단 출력 프로그램

        for (int i = 2; i <= 9; i++)
        {
            Console.Write($"{i, 6}단 ");

        }
        Console.WriteLine();

        for (int i = 2; i <= 9; i++)  // 행 출력
        {
           
            for (int j = 2; j <= 9; j++)  //열 출력
            {
                Console.Write($" {j} x {i} = {i * j,2}"); // 줄 정렬
            }
            Console.WriteLine();
        }


        //while(조건식) {실행문;}  -- while문은 반복 횟수가 명확하지 않을 때 주로 사용한다
        //안녕하세요 출력 
        int count = 0; //초기식
        while (count < 3) // 조건식
        {
            Console.WriteLine("안녕하세요"); //실행문
            count++;  //증감식
        }

        //카운트 다운
        int i = 5;
        while (i >= 1)
        {
            Console.WriteLine("카운터 : {0}",i);
            i--;
        }

        //1~3까지 카운트 업
        int count = 1;
        while(count <= 3)
        {
            Console.WriteLine($"카운트 : {count}");
            count++;
        }

      

        //1~100까지 정수의 합 구하기
        int num = 1;
        int sum = 0;
        while (num <= 100)
        {
            sum += num;
            Console.WriteLine($"1부터 {num}까지의 합 : {sum}");
            num++;

        }

        //1부터 100까지 짝수의 합 구하기

        int sum = 0;

        int i = 1;
        while (i <= 100)
        {
            if(i % 2 == 0)  // 필터링 조건처리
            {
                sum += i;
            }
            i++; // 증감식 뺴먹지 말자
        }

        Console.WriteLine($" 1부터 100까지 짝수의 합 : {sum}");
        

        //피보나치 수열 출력 프로그램
        int first = 0;
        int second =1;

        while (second <= 20)
        {
            Console.WriteLine(second);
            int temp = first + second;    //temp은 두 변수 합
            first = second; 
            second = temp;  // 두 변수합을 second에 저장

        }


        //안녕하세요 출력
        int count = 0;
        do
        {
            Console.WriteLine("안녕하세요.");
            count++;
        } while (count < 3);

        //1부터 5까지 합
        int sum = 0;
        int i = 1;

        do
        {
            sum += i;
            i++;
        } while (i <= 5);

        Console.WriteLine("1부터 5까지의 합 : {0}", sum);


        //1~ 100까지 3의 배쉬이면서 4의 배수인 정수 합 구하기

        int sum = 0;
        int i = 1;

        do
        {
            if ((i % 3 == 0 && i % 4 == 0))
            {
                sum += i;
            }
            i++;
        } while (i <= 100);

        Console.WriteLine(sum);


        //문자열에서 문자 하나씩 뽑아 출력

        string str = "ABC123";

        foreach(char c in str)
        {
            Console.Write($" {c}\t");
        }
        Console.WriteLine();


        //문자열에서 문자 하나씩 뽑기 2

        var str = "ABC123";

        foreach( var c in str)
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();


        for (int i = 0; i< 5; i ++)
        {
            if(i >=0 )
            {
                break;
            }
        }


        //무한 루프에서 탈출하기
        int number = 0;

        while(true)
        {
            Console.WriteLine(++number);

            if(number >= 5)
            {
                break;
            }
        }

        //5번 반복 후 탈출하기
        for (int i = 0; i < 100; i++)
        {
            if (( i == 5))
            {
                break;
            }
            Console.Write($"{(i + 1)}번 반복\t");
        }
        Console.WriteLine();

        //1~10에서 정수합이 22이상 되면 정지
        int goal = 22;
        int sum = 0;

        int i = 1;
        while(i <= 10)
        {
            sum += i;

            if(sum >= goal)
            {
                break;
            }

            i++;
        }

        Console.WriteLine($"1부터 {i}까지의 합은 {sum}이고, 목표치 {goal}이상을 달성했습니다.");


        for(int i =1; i<= 5; i++)
        {
            if(i % 2 == 0)
            {
                continue;  //continue문은 현재 반복의 “남은 코드”를 건너뛰고 다음 반복으로 즉시 이동

            }
            Console.WriteLine(i);
        }

        //goto문 -- 거의 사장되서 잘 안씀
        Console.WriteLine("시작");
    Start:
        Console.WriteLine("0,1,2 중 하나 입력 : _\b");
        int chapter = Convert.ToInt32(Console.ReadLine());

        if(chapter == 1)
        {
            goto Chapter1;
        }
        else if (chapter == 2)
        {
            goto Chapter2;
        }
        else 
        {
            goto End;
        }

    Chapter1:
        Console.WriteLine("1장입니다.");
    Chapter2:
        Console.WriteLine("2장입니다.");

        goto Start;

    End:
        Console.WriteLine("종료합니다.");


        int[] inArray = new int[3]; // 길이가 3인 정수형 배열 선언_메모리 할당이 된상태.int[] inArray 이렇게만 선언하면 메모리 할당이 안된 상태라서 오류가 발생한다. new int[3]으로 메모리 할당을 해줘야한다.     
        //여기서 3은 첨자,인덱스 값의 개수 라고 한다.
        
         
         //int[,] arr = new int[2, 3]; //첨자가 2개이상을 사용하는 배열은 다차원 배열이라고 한다-이 배열은 2차원 배열이다.
       
         


        //1차원 배열 선언 및 초기화

        int[] inArray;
        inArray = new int[3];

        inArray[0] = 1;
        inArray[1] = 2;
        inArray[2] = 3;

        for (int i = 0; i < 3; i++) // 정확하게 배열의 범위를 알고있을떄
        {
            Console.WriteLine($"{i}번쨰 인덱스 : {inArray[i]}");
        }

        foreach(int intValue in inArray) // inArray에 데이터가 있는 동안 반복
        {
            Console.WriteLine("{0}", intValue);
        }

        

        //1차원 배열 -배열 선언과 동시에 초기화,요소 생성


        int[] inArray = new int[3] { 1, 2, 3 }; 
        for (int i= 0;  i < 3; i++ )
        {
            Console.WriteLine($"{i}번째 인덱스 : {inArray[i]}");
        }

        foreach(int inValue in inArray)
        {
            Console.WriteLine("{0}", inValue);
        }


        

        //1차원 배열3 -배열 선언과 동시에 초기화, 요소 생성, 길이 자동으로 결정.var 키워드로 코드 줄이기

        var inArray = new int[] { 1, 2, 3 }; 

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i}번째 인덱스 : {inArray[i]}");
        }
        foreach (int inValue in inArray)
        {
            Console.WriteLine("{0}", inValue);
        }


        */


        //1차원 배열4-

        var inArray = { 1, 2, 3 };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i}번째 인덱스 : {inArray[i]}");
        }
        foreach (int inValue in inArray)
        {
            Console.WriteLine("{0}", inValue);

        }




    }
}
