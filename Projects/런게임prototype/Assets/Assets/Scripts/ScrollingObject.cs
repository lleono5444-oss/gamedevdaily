using UnityEngine;

namespace RunGame
{
    public class ScrollingObject : MonoBehaviour
    {

        public float speed = 10f; //이동속도


        private void Update()
        {
            //게임 오브젝트를 일정 속도로 왼쪽으로 평형이동하는 처리
            
            if (!GameManager.instance.isGameover) //게임 오버가 아니라면
            {
                //초당 speed 의 속도로 왼쪽을 평행이동
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            
        }
    }
}

