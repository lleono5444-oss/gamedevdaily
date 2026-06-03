using System;
using System.ComponentModel.Design;


namespace 자료구조와알고리즘
{
    public class MiddleNum
    {
        public static int a;
        public static int b;
        public static int c;
        
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.WriteLine("세 수의 중앙값 구하기");
            for (int i = 0;i < numbers.Length; i++)
            {
                Console.WriteLine("수를 입력하세요");
                if (int.TryParse(Console.ReadLine(), out int x)) numbers[i] = x;
                else
                {
                    Console.WriteLine($"잘못 입력하셨습니다.");
                    i--;
                    continue;
                }
                 a = numbers[0];
                 b = numbers[1];
                 c = numbers[2];

                Console.WriteLine($"중앙값 :{Mid(a,b,c)}");

            }
        }
        public static int Mid(int a,int b,int c)
        {
            if (a >= b)
            {
                if (b >= c) return b;
                else if (a <= c) return a;
                else return c;
            }
            else if (a > c) return a;//a < b
            else if (b > c) return c; //  a< b && a <=c
            else return b; // a < b  && a <=c && b <= c => a < b < c

            //헷갈렸던거는 두번째 else if 부터 범위를 선정할때 if문 범위로 설정한 a >=b 로 돌아가는줄 알고 헷갈렷다.
            // 요지는 else if로 분기 된 영역중에서 분기를 해야한다는 것이다. 처음 설정된 if문에 따른 영역이 설정된 것은 고정이 된다.


            //if ( c <= a && a <= b) || (b <= a && a <= c)) return a; 
            //else if (c < b && b < a) || (a < b && b > c) return b;
            //else return c;
            //이것이 효율이 더 떨어지는 이유?
            //분기를 통해 얻은 정보를 다음 분기에서 재사용하느냐





        }


    }
}




