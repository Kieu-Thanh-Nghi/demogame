using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : StateBehavior
{
    public override void FixedUpdateState()
    {
        _stateActions.MoveProcess();
    }

    public override void UpdateState()
    {
        _stateActions.JumpProcess();
        if (_changeState.JumpToIdle()) _animator.Play("Idle");
        if (_changeState.toAttackState()) _animator.SetTrigger("AttackTrigger");
        if (_changeState.toStrikeState()) _animator.Play("Strike");
        if (_changeState.toFlyKickState()) _animator.Play("FlyKick");
    }
}
