using System;

class Cosmos
{
    static void Main(string[] args)
    {
        //if_Else_lf();
        //For();
        //Switch_Case();
        //While();
        //Exercises1();
        Array();



        /*if문 (if~else if)
         * if(조건식1)
         * {
         *조건식이 1이 참일떄 실행되는 코드
         *}
         *else if (조건식 2)
         *{
         *
         *}
         *else문
         *{
         *조건식 1,2가 거짓일떄 실행되는 코드
         *}
         */

        //조건식이 많을경우 발생할수 있는 프로세스 과다사용을 방지하는 대책방안-switch문


        static void Exercises1()
        {
            //사용자에게 점수를 입력받아서기준에 따라학점을 출력하는 로직 작성해봅시다.
            

            //string  => int 형변환
            //90 이상 
            //80이상  90미만b
            //70이상  80 미만c
            //60이상 70 미만 d
            //60 미만 f

            Console.WriteLine("==========");
            Console.WriteLine("숫자를 입력하세요");
            string input = Console.ReadLine();

            /*
             * int.TryParse(input, out int score);
            bool.TryParse(input, out bool isSame);
            Console.ReadLine($" score : {score}");
            */

            //해당 입력값에서 파싱이 가능하면 참/거짓 과 값을 같이 반환
            //게임 데이터 테이블//드라이브에 있는 데이터(문자에 있는 데이터)를 메모리로 옮기는 작업을 파싱한다고 한다

            if (int.TryParse(input, out int score))
            {
                Console.WriteLine($" 형변환에 성공했습니다!. score : {score}");
                string result = "F";
                if (score >= 90) result = "A";   // 이렇게 한줄로 나오게끔 깔끔하게 코드를 짜려고 연습해야한다. 반복적인 cw부분을 별도로 뺴고 변수값에 따른 조건 변수 판단만 if문 내에서 돌게하는게 베스트
                else if (80 <= score && score < 90) result = "B";
                else if (score >= 70) result = "C";
                else if (score >= 60) result = "D";
                else result = "F";

                Console.WriteLine($" {result} 학점입니다."); 
            }
            else
            {
                Console.WriteLine($" 형변환에 실패했습니다!. score : {score}");

            }

            


        }

    }
    static void For()
    {
        /* 반복문이란?
         * 
         * 특정 조건을 만족하는 동안, 정해진 코드 블록을
         * 반복적으로 실행하는 제어문 입니다./
         * for문 while문 do while문이 있습니다
         * 
         * for문 의 문법 구조
         * 
         * for(초기화식 ; 조건식 ; 증감식)
         * {
         *              반복적으로 실행할 코드
         *}
         *초기화식 반복문에서 사용할 변수를 선언 및 초기화
         *조건식 반복문을 계속 실행할지 판단하는 식(반복문의 중단을 담담)
         *증감식 변수를증가 혹은 감소시키는 식
         */


        /* for(int i = 0;  i <= 10;++i)  //선위/후위 증감연산자는 잘 안사용함 //반복되는 횟수와 원리를 숙달될 만큼 연습하자
         {
             Console.WriteLine($"{i} 번째 반복하고 있습니다.");
         }

        
         //1-10까지의 합을 출력하는 로직을 작성해 보세요
        */
        //1.sum에 지속적으로 뭔가를 더해주면 됩니다.
        Console.WriteLine("=============================");
        int sum = 0;
        for (int i = 1; i <= 10; ++i) //매우 중요함 많이 풀어보기
        {
            sum += i; //sum = sum + i의 축약 표현입니다
        }
        Console.WriteLine($"1~10의 총합은{sum}입니다. ");

        //0~100까지의 숫자중 짝수만 출력하는 로직을 작성해봅시다

        for(int i = 0; i <= 100000; ++i)
        {
            if( i % 10 == 0) Console.WriteLine($"{i}"); // 선택창에서의 토글을 구현할수 있을꺼같은데
            {

            }
            
            
           
        }


    } // 범위가 제한 되었을때 주로 사용
    static void While() //특정한 조건이 만족하는 동안 반복할때 사용 -게임 캐릭터 대기상태일때 대기모션을 반복적으로 재생하는 등에 사용한다.//데이터의 종류가 예측불가능성을 띌떄 주로 사용한다.
    {
        /*While문
         *while(조건식)
         *{
         *          반복적으로 실행할 코드
         *}
         *조건식이 참인 동안, 코드 블록을 반복적으로 실행합니다
         *while은 특정한 조건을 만족하는 동안
         *계속 반복해야 할떄 주로 사용합니다.
         *
         */

       

        bool isPlaying = true;

        while(isPlaying) //탈출조건을 잘 정의해야한다.
        {
            Console.WriteLine("--------명령어를 입력하세요 --------");
            Console.WriteLine("Start, Load, Option,Exit 중 하나를 입력하세요");

            string menuName = Console.ReadLine();

            switch (menuName)
            {
                case "Start":
                    Console.WriteLine("게임을 시작합니다!");
                    break;
                case "Load":
                    Console.WriteLine("게임을 불러옵니다!");
                    break;
                case "Option":
                    Console.WriteLine("옵션에 진입합니다!");
                    break;
                case "Exit":
                    Console.WriteLine("게임을 종료합니다!");
                    isPlaying = false;
                    break;
                default:
                    Console.WriteLine("게임을 종료합니다!");
                    break;
            }
        }
        

        
    }

    static void if_Else_lf()
{
    /*if 문
        * if(조건식)
        * {
        *          조건식이 참일때 실행되는 코드
        *  }
        *  else 문
        *  {
        *          조건식이 거짓일떄 실행되는 코드
        *  }
        *  명제와 유사한 메서드
        *  bool타입만 괄호 안에 넣을수 있다.
        *  총알의 피격 판정 등에 활용한다.
    */


    int number = 0;
    bool isBigger = number > 3;
    /*if문을 괄호안에 직접적인 조건을 넣기 보단
        * bool 변수값을 넣고 밖에서 가져오는 식으로 설정할 수 있다.
        * 
        */

    if (number > 3)
    {
        Console.WriteLine($"number는 3보다 큽니다 . True");
    }
    else
    {
        Console.WriteLine($"numbersms 3보다 크지 않습니다. False");
    }



    int age = 19;
    if (age <= 13) //else이 꼭 쌍으로 있을필욘없다. 해당 조건 외는 실행이 안되는식으로 설정한지
        Console.WriteLine($"age = {age}, 어린이 입니다");
    else if (age <= 19)
        Console.WriteLine($"age = {age}, 청소년 입니다");
    else
        Console.WriteLine($"age = {age}, 성인 입니다");
    //if else문외 귀속된 하위 if else문 생성이 코드가 망가진다는 왜?
    //일단 그래서 if elseif else문을 사용한다.
    //조건문이 한줄일경우 블록을 설정안하고 작성 가능하다.코드가 깔끔해진다.

}
    static void Switch_Case()
    {
        /*switch(비교할 함수)
         * {
         *      case 값1 :
         *                  변수의 값이 '값1'과 일치할때 실행될 코드
         *      break;
         *      case 값1 :
         *                  변수의 값이 '값1'과 일치할때 실행될 코드
         *      break;
         *      
         *      default :
         *              //위 어떤 case와도 일치하지 않을때 실행될 코드
         *      break;
         *  }
         */




        Console.WriteLine("========");

        Console.WriteLine("메뉴를 선택하세요");

        string input = Console.ReadLine();
        //Console.ReadLine();
        //콘솔에게 다음 입력을 읽어서 저장하라고 명령하는 함수입니다.

        //Console.WriteLine($"사용자는 '{input}!' 을 입력했습니다.");

        switch (input)
        {
            case "1":
                Console.WriteLine("1. 새로운 게임을 시작합니다..."); //;이 아니라 :임을 주의하자
                break;
            case "2":
                Console.WriteLine("2. 저장된 데이터를 불러옵니다...");
                break;
            case "3":
                Console.WriteLine("3. 설정 메뉴를 엽니다...");
                break;
            case "4":
                Console.WriteLine("4. 게임을 종료합니다...");
                break;
            default:
                Console.WriteLine("잘못된 입력입니다. 1~4 사이의 숫자를 입력하세요.");
                break;
                //break문을 지우고 활용할 수도 있다는데 어떻게 설정하는지?
                //생각해 볼수 있는거는 키입력 메서드를 제작하고 그걸 switch문을 넣어서 가능할꺼같다.
                //패드의 진동설정은 어떻게 하는가?
                //케이스에 걸리지 않을경우 예외처리
                //if는 조건에 따른 판단/ swicth는 (특수)데이터의 상태를 보고 판단한다
                //break는 코드 블록을 탈출하는 것
                //break를 지우면 해당 데이터가 들어올시 그 다음 데이터의 케이스를 실행한다.
                //어떻게 활용할 수 있을까?


        }
    }

    static void Array()
    {
        /*배열(Array)
         * 같은 종류(같은 자료형)의 데이터를 여러개를 하나의 묶음으로 관리하기 위한 수단
         * 변수처럼 선언,할당,초기화,재할당 등이 가능합니다
         * 
         * 1.배열의 선언 및 할당
         */

        int[] numberArray = new int[3];//new 뒤에 변수 크기 만큼의 공간을 할당하라는 동적할당 명령어 : new
        //int[] numberArray : int 자료형 묶음인 numberArray 변수를 선언 
        //new int[3] : int 자료형 데이털 3개를 보관할 수 있는 공간을 만들어줘

        numberArray[0] = 10;
        numberArray[1] = 20;
        numberArray[2] = 30;

        Console.WriteLine($"numberArray의 0번째 요소{numberArray[0]}");
        Console.WriteLine($"numberArray의 1번째 요소{numberArray[1]}");
        Console.WriteLine($"numberArray의 2번째 요소{numberArray[2]}");

        //2.배열의 요소에 접근하는 방법
        //배열의 요스는 indexer[숫자를 의미]를 통해 접근 할수 있습니다.

        //for문과 합칠때 시너지가 좋다


        int sum = 0;
        
        for(int i = 0; i < numberArray.Length; i++)  //Length는 앞 변수의 길이를 int값으로 반환
        {
            sum += numberArray[i];
        }
        Console.WriteLine($"numberArray의 총합은{sum}입니다");




        //반복문의 배열을 이용한 초기화


        int[] loopArray = new int[100];

        for(int i =0; i < loopArray.Length; i++)//내가 다룰 데이터가 예측가능성이 있을때 for문을 사용한다.
        {
            loopArray[i] = 0;
        }
        for (int i = 0; i < loopArray.Length; i++)
            Console.WriteLine($"loopArray의 {i}번째 요소는 {loopArray[i]}입니다");

        //10을 더하는 로직
        for (int i = 0; i < loopArray.Length; i++)  
        {
            loopArray[i] += 10;
        }
        for (int i = 0; i < loopArray.Length; i++)
            Console.WriteLine($"loopArray의 {i}번째 요소는 {loopArray[i]}입니다");
        //i가 짝수라면 -5를 하는 로직을 만들어봅시다.
        for (int i = 0; i < loopArray.Length; i++)//내가 다룰 데이터가 예측가능성이 있을때 for문을 사용한다.
        {
            if(i % 2 == 0) loopArray[i] *= -1;
        }

        Console.Clear();
        
        for (int i = 0; i < loopArray.Length; i++)
        {
            //음수일경우 출력을 건너뛰는 로직
            //사실 아래처럼도 할수 있는지만
            /*if (loopArray[i] > 0)
            {
                Console.WriteLine($"loopArray의 {i}번째 요소는 {loopArray[i]}입니다");
            }
            */
            Console.WriteLine($"현재 i = {i}");
            continue;
            //if (loopArray[i] < 0) continue;
                Console.WriteLine($"loopArray의 {i}번째 요소는 {loopArray[i]}입니다");
        }
            
        //왜 짝수 if문 조건이 for문에도 적용되는건지 천천히 되짚어보기

        //제어와 배열을 배웠다




    }


}