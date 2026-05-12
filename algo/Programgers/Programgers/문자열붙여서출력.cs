using System;

public class Example10
{
    public static void Main10()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];

        Console.WriteLine($"{s1}{s2}");

    }
}

/*다른 사람 풀이

using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];
        string sum = s1+s2;
        sum = sum.Trim();
        Console.WriteLine(sum);

    }
}
TrimStart(),TrimEnd(),Trim()
각각 시작 공백 제거,마지막 공백 제거,양쪽 공백 제거 기능

 */
