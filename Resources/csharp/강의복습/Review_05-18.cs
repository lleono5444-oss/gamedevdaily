using System;
using UnityEngine;
using System.Collections.Generic;


namespace Review_DataStructure
{
    public  class Review_05_18 : MonoBehaviour
    {
              /*
     * 2차원 배열
     */
        public void Start()
        {
            //array2D();
            List();
        }

        public void array2D()
        {

            int[,] gameBoard = new int[3, 3];
            string[,] characters =
            {
                 { "전사", "마법사", "궁수" },
                { "힐러","탱커","도적" }
            };

            Debug.Log($"characters [0,0] 값 : {characters[0, 0]}");
            Debug.Log($"characters [0,1] 값 : {characters[0, 1]}");
            Debug.Log($"characters [0,2] 값 : {characters[0, 2]}");
            Debug.Log($"characters [1,0] 값 : {characters[1, 0]}");
            Debug.Log($"characters [1,1] 값 : {characters[1, 1]}");
            Debug.Log($"characters [1,2] 값 : {characters[1, 2]}");
            Debug.Log("");

            characters[0, 1] = "서포터";

            Debug.Log($"characters [0,0] 값 : {characters[0, 0]}");
            Debug.Log($"characters [0,1] 값 : {characters[0, 1]}");
            Debug.Log($"characters [0,2] 값 : {characters[0, 2]}");
            Debug.Log($"characters [1,0] 값 : {characters[1, 0]}");
            Debug.Log($"characters [1,1] 값 : {characters[1, 1]}");
            Debug.Log($"characters [1,2] 값 : {characters[1, 2]}");
            Debug.Log("");

        }


        public void List()
        {

            List<string> fruitBasket = new List<string>();

            Debug.Log("1. List 생성 직후");
            Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");
            Debug.Log("");

            fruitBasket.Add("사과");
            fruitBasket.Add("딸기");
            fruitBasket.Add("바나나");
            fruitBasket.Add("딸기");
            Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");
            for (int i = 0; i < fruitBasket.Count; i++)
            {
                Debug.Log($"fruitBasket[{i}] : {fruitBasket[i]}");
            }
            Debug.Log("");




            fruitBasket.Remove("딸기");
            Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");
            for (int i = 0; i < fruitBasket.Count; i++)
            {
                Debug.Log($"fruitBasket[{i}] : {fruitBasket[i]}");
            }
            Debug.Log("");


            fruitBasket.RemoveAt(2);
            Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");
            for (int i = 0; i < fruitBasket.Count; i++)
            {
                Debug.Log($"fruitBasket[{i}] : {fruitBasket[i]}");
            }
            Debug.Log("");

            fruitBasket.Add("오렌지");
            fruitBasket.Add("오렌지");
            fruitBasket.Add("파인애플");
            fruitBasket.Add("오렌지");
            fruitBasket.Add("오렌지");
            fruitBasket.Add("샤인머스캣");
            fruitBasket.Add("오렌지");
            Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");

            for (int i = 0; i < fruitBasket.Count; i++)
            {
                Debug.Log($"fruitBasket[{i}] : {fruitBasket[i]}");
            }
            Debug.Log("");


            fruitBasket.Insert(2, "오렌지");
            Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");

            for (int i = 0; i < fruitBasket.Count; i++)
            {
                Debug.Log($"fruitBasket[{i}] : {fruitBasket[i]}");
            }
            Debug.Log("");

            string name = "오렌지";
            /*
             * 기존 코드
            for(int i = 0; i < fruitBasket.Count; i++)
            {
               
                if (fruitBasket.Contains(name))
                {
                    Debug.Log($"List 안에 {name}이 삭제되었습니다");
                    fruitBasket.Remove(name);
                }
                else
                {
                    Debug.Log($"List 안에 {name}이 없습니다.");
                }
                Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");
                for (int j = 0; j < fruitBasket.Count; j++)
                {
                    Debug.Log($"fruitBasket[{j}] : {fruitBasket[j]}");
                }
                Debug.Log("");
            }

            for (int i = fruitBasket.Count-1; i >= 0; i--)
            {

                if (fruitBasket.Contains(name))
                {
                    Debug.Log($"List 안에 {name}이 삭제되었습니다");
                    fruitBasket.Remove(name);
                    Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");
                    foreach(string fruit in fruitBasket)
                    {
                        Debug.Log($"fruitBasket : {fruit}");
                    }
                    Debug.Log("");
                    
                }
                else
                {
                    Debug.Log($"List 안에 {name}이 없습니다.");
                    break;
                }
            
            /*
             * 문제:오렌지를 삭제한 이후 전체 리스트 출력이 안됨,
             *      List의 크기가 삭제를 거듭하면서 줄어드는데
             *      반복 횟수를 거듭할수록 출력되는 
             *      리스트가 오렌지 이외의 것들도 출력이 안되며
             *      반복문이 중간에 중단된다.
             *      내부 반복문이 실행이 이상하게됨
             * 원인: 리스트의 크기는 회차를 반복할수록 줄어드는데 반복문의 변수는 계속 커지기 때문에
             *     반복문이 중간에 중단되는 것이다.
             *     
             *          
             * 시도: 
             *
             *해결책: 콘솔창에 결과값 출력을 collapse를 켜서 진행해 전체를 제대로 볼수 없었다. 해당 키 비활성화
             *1.조건문과
             *2.앞에서 삭제를 하면 삭제후 인덱스가 당겨지는데
             * 뒤에서 삭제하면 검사한 영역엔 영향이없어지기 떄문이다.
             * 배운점: 반복문 내 조건문의 설정이 아직 비흡했다.
             * 반복문을 설정할떄 초기식 조건식 증감식을 설정할때마다 왜 그렇게 설정하는지 머릿속으로
             *라도 설명할수 있어야한다
             *
             */

            //바꾼 코드


            for (int i = fruitBasket.Count - 1; i >= 0; i--)
                {
                    if (fruitBasket[i] == name)
                    {
                        Debug.Log($"List 안에 {name}이 삭제되었습니다");

                        fruitBasket.RemoveAt(i);

                        Debug.Log($"쇼핑백 안의 과일 개수 : {fruitBasket.Count}");

                        foreach (string fruit in fruitBasket)
                        {
                            Debug.Log($"fruitBasket : {fruit}");
                        }

                        Debug.Log("");
                    }
                }

                Debug.Log($"List 안에 남아있는 {name} 검사 완료");

                //굳이 내부 반복문을 for으로 설정할 필요가 있는가?
                //foreach문을 써야하나


            }
          
     }

}

  





