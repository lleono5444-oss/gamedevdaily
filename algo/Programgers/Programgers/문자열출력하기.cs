using System;


/*문자열 str이 주어질 때, str을 출력하는 코드를 작성해 보세요.

    제한사항
    1 ≤ str의 길이 ≤ 1,000,000
    str에는 공백이 없으며, 첫째 줄에 한 줄로만 주어집니다.
 */
public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        if (1 <= s.Length && s.Length <= 1000000)
        {
            Console.WriteLine(s);
        }

    }
}

//다른 사람의 풀이
public class Example1
{
    public static void Main1()
    {
        String s = "HelloWorld!";
        Console.Clear();
        s = Console.ReadLine();
        s = s.Replace(" ", "");
        if (1 > s.Length || s.Length > 1000000) return;
        Console.Write(s);
    }
}

/*공백에 대한 처리부분 s = s.Replace(" ", "");에 대해 알아보자
 * 
 * 기본적인 기능은 문자열을 다른패턴으로 치환하는 것이다
 * 괄호의 첫번째 값을 두번째 값으로 치환후 그걸 s에 재할당하는 것인데(재할당 과정이 있어야 실제 데이터가 할당된다)
 * 
 * 실제 게임에서의 욕설 필터링이나 유저가 공백을 입력했을때 자동처리 등이 가능하다고한다
 * 예를 들어 문제풀이 프로그램이 있다는 가정하에 유저의 입력값에 공백이 포함되었을 시 컴퓨터는 그걸 
 * 다른 값으로 인식한다. 하지만 이 치환 과정을 거치면 컴퓨터가 알아들을 수 있는 데이터 형태로 재가공되는 것이다.
 * 
 */