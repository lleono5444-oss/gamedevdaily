using UnityEngine;

public abstract class EntityState
{
    protected Player player;
    protected StateMachine stateMachine;
    protected string animBoolName;

    protected Animator anim;
    protected Rigidbody2D rb;
    protected Player_InputSet input;

    protected float stateTimer;



    public EntityState(Player player, StateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;

        anim = player.anim;
        rb = player.rb;
        input = player.input;
    }

    public virtual void Enter()
    {
        //상태가 변경될때마다 호출됨
        anim.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        //상태로직  실행
        stateTimer -= Time.deltaTime;
        anim.SetFloat("yVelocity", rb.linearVelocity.y);
        if (input.Player.Dash.WasPressedThisFrame() && CanDash())
            stateMachine.ChangeState(player.dashState);
    }


    public virtual void Exit()
    {
        //상태를 종료하고 새 상태로 변경할때마다 호출됩니다.

        anim.SetBool(animBoolName, false);
    }

    private bool CanDash()
    {
        if (player.wallDetected) return false;
        if (stateMachine.currentState == player.dashState) return false;
        return true;
    }

}
