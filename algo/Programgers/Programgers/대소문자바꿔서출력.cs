using System;
using System.Text; // StringBuilder를 쓸려면 써야한다. 여기 소속 라이브러리다
public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        StringBuilder sb =new StringBuilder();
       
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLower(s[i])) sb.Append(char.ToUpper(s[i])); 
            else sb.Append(char.ToLower(s[i]));
       
        }
        Console.WriteLine(sb);
    }
}

/*다른 사람 풀이
using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach (char c in s) //foreach문 연습 많이 해보기
        {
            if (char.IsUpper(c))
            {
                Console.Write(char.ToLower(c));
            }
            else
            {
                Console.Write(char.ToUpper(c));
            }
        }
    }
}


너무 StringBuilder에 매몰 되지는 말고 풀 수 있는 방법이 있다면 다 써보는 식으로 진행하자
*/

//char.ToUpper(ch)
//char.ToLower(ch)