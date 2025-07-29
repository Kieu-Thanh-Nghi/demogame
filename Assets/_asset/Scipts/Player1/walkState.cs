using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkState : StateBehavior
{
    public override void FixedUpdateState()
    {
        _stateActions.MoveProcess();
    }

    public override void UpdateState()
    {
        if (_changeState.toIdleState())
        {
            _animator.Play("Idle");
        }
        if (_changeState.toJumpState())
        {
            _animator.Play("Jump");
        }
        if (_changeState.toCrouchState()) _animator.Play("Crouch");
        if (_changeState.toAttackState()) _animator.Play("Attack");
        if (_changeState.toStrikeState()) _animator.Play("Strike");
        if (_changeState.toFlyKickState()) _animator.Play("FlyKick");
    }
}
