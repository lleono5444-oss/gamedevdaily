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
            if (char.IsLower(s[i]) sb.Append(char.ToUpper(s[i])); 
            else sb.Append(char.ToLower(s[i])); ;
       
        }
        Console.WriteLine(sb);
    }
}

//char.ToUpper(ch)
//char.ToLower(ch)