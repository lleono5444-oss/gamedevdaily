using System;

public class Solution1
{
    public int solution(int number, int n, int m)
    {
        int answer = 0;

        if (number % n == 0 && number % m == 0)
        {
            answer = 1;
        }

        return answer;

    }
}

/*
 * 

using System;

public class Solution {
    public int solution(int number, int n, int m) {
        return number%n == 0 && number%m == 0 ? 1 : 0;
    }
}
삼항 연산자를 사용한 풀이
 */