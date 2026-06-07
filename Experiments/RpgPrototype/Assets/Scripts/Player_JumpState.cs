public class Player_JumpState : Player_AirState
{
    public Player_JumpState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {

    }


    public override void Enter()
    {
        base.Enter();
        player.SetVelocity(rb.linearVelocity.x, player.jumpForce);
       
        //yVelocity가 마이너스이면 fall로 전환
    }

    public override void Update()
    {
        base.Update();
        if (rb.linearVelocity.y < 0)
            stateMachine.ChangeState(player.fallState);
    }


}
