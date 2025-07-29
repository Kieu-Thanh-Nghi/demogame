using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : StateBehavior
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        _stateActions.JumpProcess();
    }
    public override void FixedUpdateState()
    {
        _stateActions.MoveProcess();
    }

    public override void UpdateState()
    {
        _changeState.toJumpState();
        if (_changeState.JumpToIdle()) _animator.Play("Idle");
        if (_changeState.toAttackState()) _animator.SetTrigger("AttackTrigger");
        if (_changeState.toStrikeState()) _animator.Play("Strike");
        if (_changeState.toFlyKickState()) _animator.Play("FlyKick");
    }
}
