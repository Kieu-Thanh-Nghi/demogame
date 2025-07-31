using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : StateBehavior
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        if (_physic.isGround)
        {
            animator.SetInteger("AttackTimes", 0);
            animator.SetInteger("StrikeTimes", 0);
            animator.SetInteger("FlyKickTimes", 0);
        }
        _stateActions.JumpProcess();
    }
    public override void FixedUpdateState()
    {
        _stateActions.MoveProcess();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _changeState.toJumpState();
        if (_changeState.JumpToIdle()) _animator.Play("Idle");
        if (_animator.GetInteger("AttackTimes") < 1 && _changeState.toAttackState()) _animator.SetTrigger("AttackTrigger");
        if (_animator.GetInteger("StrikeTimes") < 1 && _changeState.toStrikeState()) _animator.Play("Strike");
        if (_animator.GetInteger("FlyKickTimes") < 1 && _changeState.toFlyKickState()) _animator.Play("FlyKick");
    }
    public override void UpdateState()
    {
    }
}
