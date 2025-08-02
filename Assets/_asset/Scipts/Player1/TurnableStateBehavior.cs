using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnableStateBehavior : StateBehavior
{
    public override void FixedUpdateState()
    {
        
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        CheckTurn();
        CheckAllAtkActions(animator);
    }

    protected virtual void CheckAllAtkActions(Animator animator)
    {
        CheckAttack(animator);
        CheckStrike(animator);
        CheckFlyKick(animator);
    }
    protected virtual void CheckAttack(Animator animator)
    {
        if (UniData._inputs.AttackInput())
        {
            animator.Play(AnimName.Attack);
        }
    }    
    
    protected virtual void CheckStrike(Animator animator)
    {
        if (UniData._inputs.StrikeInput())
        {
            animator.Play(AnimName.Strike);
        }
    }    
    
    protected virtual void CheckFlyKick(Animator animator)
    {
        if (UniData._inputs.FlyKickInput())
        {
            animator.Play(AnimName.FlyKick);
        }
    }
    protected virtual void CheckTurn()
    {
        UniData._playerCtrl.GetComponent<TurnSprite>().Turn(Input.GetAxis("Horizontal"));
    }
}
