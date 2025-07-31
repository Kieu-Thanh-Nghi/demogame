using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBehavior : StateMachineBehaviour
{
    [SerializeField] protected Animator _animator;
    [SerializeField] protected PlayerControl _playerCtrl;
    [SerializeField] protected SetStateActions _stateActions;
    [SerializeField] protected ChangeStateController _changeState;
    [SerializeField] protected PlayerPhysic _physic;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _playerCtrl.state = this;
    }
    public void setUpState(Animator animator)
    {
        _animator = animator;
        _playerCtrl = animator.GetComponent<PlayerControl>();
        _stateActions = _playerCtrl.GetComponent<SetStateActions>();
        _changeState = _playerCtrl.GetComponent<ChangeStateController>();
        _physic = _playerCtrl.GetComponent<PlayerPhysic>();
    }

    public abstract void UpdateState();
    public abstract void FixedUpdateState();
}
