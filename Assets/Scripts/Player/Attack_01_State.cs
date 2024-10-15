using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_01_State : AttackState
{
    public Attack_01_State(Player player, PlayerStateMachine stateMachine, string animParameterName) : base(player, stateMachine, animParameterName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        player.attackComboo = (player.attackComboo+1) % 3;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }
}
