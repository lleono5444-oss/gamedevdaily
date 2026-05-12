using System;

public class Example2
{
    /*
     *문제 설명
        정수 a와 b가 주어집니다. 각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.

        제한사항
        -100,000 ≤ a, b ≤ 100,000 
     */

    public static void Main2()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
        
        //내가 작성한 부분
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }

    /*
     * 코드해석하기
     * 
     * 문자열 형태의 배열을 선언
     * 
     * Console.Clear();
     *  콘솔화면을 전부 지우는 기능
     *      게임적으로 봤을때 떠오른 사용처는 ui의 고정이 있는것 같다
     *          ui가 계속 한자리에 있는것 처럼 보이는게 사실은 계속 새값을 갱신하고 있는 것이다.
     * 
        s = Console.ReadLine().Split(' ');
            입력된 문자열을 공백 기준으로 나누어 문자열 배열에 저장한다.
                게임적으로는 귓말이 예시가 된다
                    /귓 대상 할말
                        이걸 공백 단위로 끊게 로직을 만들어서 각각 데이터를 구분지어서 역할별로 실행되게끔하는 기능
            
        다른 유저의 풀이를 보면 괄호에 안에 별도의 기준점을 설정을 안했는데 디폴트값이 모든 공백류 기준이다.
            이말의 의미는 공백이 하나만 있을때는 내꺼도 이상없이 작동을 하지만, 난 명시적으로 공백 한칸단위를 기준값으로 잡았기때문에
            공백이 여러개일시 공백 자체도 변수로 저장될수 있다는 점이다.
            

        배열 인덱스 0과 1을 int형으로 변환후 각각 int a와 b에 저장
        
        두 요소를 같이 출력한다
    
        각각 요소별로 출력한다.

    ToArray();
    현재 데이터를 배열(Array) 형태로 변환한다.
        내가 배우기로 array는 크기가 고정되어있고 사전에 정의를 해야지만 요소를 할당할수 있는데
            하지만 ToArray()는 현재 데이터 개수를 기반으로 알맞은 크기의 배열을 자동 생성하고 값들을 저장한다.
     */

    /* 다른 유저 풀이
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

            namespace ConsoleApp1
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        int[] are = Console.ReadLine().Split().Select(int.Parse).ToArray();
                        int a = are[0];
                        int b = are[1];
                        Console.WriteLine($"a = {a}\nb = {b}");
                    }
                }
            }


            한눈에 봐도 기능을 압축적으로 표현했다는게 느껴진다.
        
    */
}