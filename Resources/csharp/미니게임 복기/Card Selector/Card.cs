using UnityEngine;
using System.Collections.Generic;


namespace CardSelector
{

    public class Card : MonoBehaviour
    {
        //    데이터
        //- 카드 숫자를 저장한다.
        //카드의 숫자는 1~ jqk 까지 13개까지 있다.
        private enum Cards
        {
            one =1,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            jack,
            queen,
            king,
        }

        //- 카드의 현재 상태(앞면, 뒷면)를 저장한다.
        //크기가 2로 고정이니 배열로 관리하자
        
        private string[] BakcAndForth = new string[2] { "Back", "Front" };

        //- 카드 앞면 이미지를 저장한다.
        //- 카드 뒷면 이미지를 저장한다.

        private List<GameObject>[] CardFlipImage;

        private void Awake()
        {
            CardFlipImage.Add(GetCompoents<SpriteRenderer>());
        }
       
    }

}