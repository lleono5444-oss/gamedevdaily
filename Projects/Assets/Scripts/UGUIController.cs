using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Reveiw.UGUI
{
    public class UGUIController : MonoBehaviour
    {
        public enum CanvasType
        {
            CanvasA = 1,
            CanvasB,
            CanvasC,
            CanvasD,
        }

        private Canvas[] canvases;
        private Canvas menuCanvas;

        private Button[] buttons;
       
        public void Awake()
        {
            canvases = GetComponentsInChildren<Canvas>();

            for(int i = 0; i < canvases.Length; i++)
            {
                if (canvases[i].gameObject.name.Equals("MenuCanvas"))
                {
                    menuCanvas = canvases[i];
                    break;
                }
            }

            SetActiveCanvas(CanvasType.CanvasA);
            SetButtons();


        }

        private void Update()
        {
            if(Keyboard.current.qKey.wasPressedThisFrame)
            {
                SetActiveCanvas(CanvasType.CanvasA);
            }

            if (Keyboard.current.wKey.wasPressedThisFrame)
            {
                SetActiveCanvas(CanvasType.CanvasB);
            }

            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                SetActiveCanvas(CanvasType.CanvasC);
            }

            if (Keyboard.current.rKey.wasPressedThisFrame)
            {
                SetActiveCanvas(CanvasType.CanvasD);
            }
        }

        public  void SetActiveCanvas(CanvasType canvasType)
        {
            for(int i = 0; i < canvases.Length; i++)
            {
                canvases[i].enabled = false;
            }
            menuCanvas.enabled = true;
            canvases[(int)canvasType].enabled = true; // 들어온 enum 값을 int값으로 반환후 해당 index에 대한 canvases를 호출해 그걸 활성화한다.
        }

        public void SetActiveCanvas(int canvasType) 
            //int값이 들어왔을때에 그 값을  CanvasType 값으로 변환해서 돌려서 기존 함수를 실행한다는건데
            //왜 이런 경우가 생기는가를 생각해보자. 딱 보기엔 예외처리를 한거 같은데
            //
        {
            SetActiveCanvas((CanvasType)canvasType);
        }

        private void SetButtons()
        {
            buttons = menuCanvas.transform.GetComponentsInChildren<Button>(); //transform은 생략가능하다고 하긴했는데 왜 transform이 들어갔는지모르겟음

            for(int i = 0; i < canvases.Length; i++)
            {
                //buttons[i].onClick.AddListener(() => SetActiveCanvas(i)); 과 아랫것의 차이 분명히 인지하기

                int index = i + 1;
                buttons[i].onClick.AddListener(() => SetActiveCanvas(index));

            }

            for( int i = 0; i < canvases.Length; i++)
            {
                //buttons[i].interactable = (i % 2 == 0);
                //아래 내용과 같지만 위가 맞는 표현


                if(i % 2 == 0)
                {
                    buttons[i].interactable = true;
                }
                else
                {
                    buttons[i].interactable = false;
                }
            }
            
        }

        
    }
}
