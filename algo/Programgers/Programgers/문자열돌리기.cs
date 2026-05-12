using System;

public class Example11
{
    public static void Main11()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach (char Ver in s)
        {
            Console.WriteLine(Ver);
        }

    }


}

/*다른 사람 풀이
 * 
 * 

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
            char[] input = Console.ReadLine().ToCharArray();
            string output = string.Join("\n", input);
            Console.WriteLine(output);
        }
    }
}

ToArray()와 ToCharArray()
이걸 보고 To와 Array 사이에 데이터 형식을 집어넣으면 되는건줄 알았는데 그건 안된다고 한다.
ToArray() 컬렉션(List 등)을 배열로 변환,타입은 자동 결정됨
ToCharArray() 문자열을 문자 배열로 변환,string 전용 메서드, 
    string은 불변(immutable)이라 문자 수정이 불가능하지만,
    char[] 배열은 각 요소를 직접 변경할 수 있어 문자 단위 가공이 가능하다.


*/