using System;

public class Example3
{
    public static void Main3()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);

        for (int i = 0; i < a; i++)
        {
            Console.Write(s1);

        }
    }
}

/* 다른 유저 풀이

using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);

        StringBuilder sb = new StringBuilder();    

        for(int i = 0; i < a; i++)
            sb.Append(s1);

        var str = sb.ToString();
        Console.WriteLine(str);
    }
}

────────────────────────────────────

StringBuilder

내 방식은 반복마다 Console.Write()를 호출한다.
출력량이 적다면 큰 차이는 없지만,
반복 횟수가 많아질수록 출력 호출 비용이 커질 수 있다.

다른 유저 방식은 StringBuilder를 사용하여
문자열을 버퍼에 계속 추가한 뒤,
마지막에 한 번만 출력한다.

즉:
반복 출력 대신
"문자열 생성 → 마지막 한 번 출력"
방식인 것이다.

상황에 따라:
- 단순 출력이면 Console.Write()
- 문자열 조합이 많다면 StringBuilder

를 고려할 수 있다.

================================================================

기존 string += 방식

"A"
↓
"AB"
↓
"ABC"

문자열(string)은 immutable(불변)이므로
+= 를 할 때마다 새 문자열이 생성된다.

즉:
1. 새 문자열 생성
2. 이전 문자열 복사
3. 새 문자열 추가

과정을 반복한다.

문자열이 길어질수록 비효율적일 수 있다.

================================================================

StringBuilder 방식

화이트보드 같은 느낌.

A 추가
B 추가
C 추가

기존 문자열을 계속 새로 만드는 것이 아니라,
내부 버퍼에 데이터를 계속 추가한다.

================================================================

Append()

Append는 버퍼 뒤에 데이터를 추가하는 함수이다.

StringBuilder sb = new StringBuilder();

위 코드는:
문자열 작업용 StringBuilder 객체를 생성하는 것이다.

for(int i = 0; i < a; i++)
    sb.Append(s1);

위 코드는:
반복문을 통해 문자열을 내부 버퍼 뒤에 계속 이어붙이는 과정이다.

마지막에:

sb.ToString();

을 호출하면
버퍼 내용을 기반으로 최종 문자열을 생성한다.

================================================================

buffer 와 temp 차이

둘 다 데이터를 잠깐 저장한다는 공통점이 있다.

하지만 역할 차이가 있다.

temp:
잠깐 값 하나를 보관하는 임시 변수 느낌이다.

예:
int temp;

buffer:
데이터를 모아두고 효율적으로 처리하기 위한
임시 저장 공간 느낌이다.

예:
StringBuilder 내부 버퍼

================================================================

변수와 저장공간

입문 단계에서는:
"변수는 값을 저장하는 공간"
이라고 배우지만,

실제로는:
데이터에 접근하기 위한 이름표에 더 가깝다.

특히 참조형(reference type)은
값 자체보다 객체의 위치(참조)를 저장한다.

예:

StringBuilder sb = new StringBuilder();

여기서 sb는
StringBuilder 객체 자체를 들고 있는 것이 아니라,
해당 객체를 가리키는 참조를 저장한다고 볼 수 있다.

즉:
sb
 ↓
[StringBuilder 객체]

같은 구조에 가깝다.

현재 단계에서는:

"변수는 데이터를 저장하거나
데이터를 가리키기 위한 이름표"

정도로 이해하면 된다.

여기서 한번 생각해 봐야하는 것은 객체와 인스턴스이다

/*Player player = new Player();

    Player
    → 클래스(설계도)

    new Player()
    → Player 객체(인스턴스) 생성

    player
    → 생성된 객체를 참조하는 변수

    객체(Object)와 인스턴스(Instance)는 혼용해서 많이 사용된다.

    객체:
    실제로 생성된 대상 자체를 강조하는 느낌

    인스턴스:
    특정 클래스로부터 생성되었다는 관계를 강조하는 느낌

    주의:
    인스턴스는 사본(copy)이 아니라
    클래스를 기반으로 새롭게 생성된 객체이다.
*/