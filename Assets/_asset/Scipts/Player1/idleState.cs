using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleState : StateBehavior
{
    public override void UpdateState()
    {
        if (_changeState.toMoveState())
        {
            _animator.Play("Walk");
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

    public override void FixedUpdateState()
    {

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
