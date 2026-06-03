using UnityEngine;
using UnityEngine.InputSystem;


//조건
//-대각선 이동 속도 일정
//"대각선 이동 시 속도가 빨라지는 문제를 해결해라"
//- Rigidbody2D 사용
//- FixedUpdate 사용


namespace Vampire_Survivors
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D rbody;
       

        private float Velocity;
        private Vector3 moveVector;

        [Header("Settings")]
        public float speed = 5.0f;


        private void Awake()
        {
            rbody = GetComponent<Rigidbody2D>();
            
            rbody.bodyType = RigidbodyType2D.Kinematic;

        }

        private void FixedUpdate()
        {
            rbody.transform.Translate( moveVector * speed * Time.fixedDeltaTime);

        }


        private void Update()
        {
            moveVector = Vector3.zero;

            if (Keyboard.current.leftArrowKey.isPressed)
            {
                moveVector += Vector3.left;
            }

            if (Keyboard.current.rightArrowKey.isPressed)
            {
                moveVector += Vector3.right;
            }

            if (Keyboard.current.upArrowKey.isPressed)
            {
                moveVector += Vector3.up;
            }

            if (Keyboard.current.downArrowKey.isPressed)
            {
                moveVector += Vector3.down;
            }
            //moveVector는 유저 입력을 받고 해당 입력에 따른 방향값을 입력받는 것이다.
            //근데 각 커맨드 위주로 입력을 받는데 속도 정규화 작업까지 할 필요가 있는가?
            //이미 들어오는 값들이 1인데 여기서 처리하면 안될꺼같다.
            moveVector = Vector3.ClampMagnitude(moveVector, 1f);//방향값 제한 + 정규화
            
           
        }

    }
}



