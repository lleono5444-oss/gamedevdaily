using System;

namespace MaxSol
{
    public class Maxsol
    {
    
        //네개 수 입력받기
        static void Main(string[] args)
        {
            int maxNum = 0;
            //List<int> numbers = new List<int>();
            int[] numbers = new int[4];
            //현재는 들어오는 수가 4개로 확정된 상태이기에

            for (int i = 0; i < numbers.Length; i++)
            {
                
                Console.WriteLine("수를 입력하세요");
                if (int.TryParse(Console.ReadLine(), out int x)) numbers[i] = x;
                else
                {
                    Console.WriteLine("수를 입력하세요");
                    i--;
                    continue;
                }
            }
            maxNum = numbers[0];

            foreach(int temping in numbers)
            {
                
                if (temping >= maxNum) maxNum = temping;
            }
           
            Console.WriteLine($"최대값 : {maxNum}");

        }

    }
    
}


