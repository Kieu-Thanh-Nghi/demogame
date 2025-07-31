using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateActions : MonoBehaviour
{
    [SerializeField] PlayerControl _player;
    [SerializeField] ScriptableObject[] scripObj;

}
interface StateFunc
{
    public void active();
}
class MoveProcess:StateFunc
{
    [SerializeField] Move _move;
    [SerializeField] TurnSprite _turn;
    [SerializeField] InputControl inputs;

    public void active()
    {
        float direct = inputs.MoveInput();
        _move.Going(direct);
        _turn.Turn(direct);
    }
}

class JumpProcess : StateFunc
{
    [SerializeField] InputControl inputs;
    [SerializeField] PlayerPhysic physic;
    [SerializeField] Jump _jump;
    public void active()
    {
        if (!physic.isUp && inputs.JumpInput())
        {
            if (physic.isGround) _jump.JumpUp();
        }
    }
}

class CrouchTurn : StateFunc
{
    [SerializeField] InputControl inputs;
    [SerializeField] TurnSprite _turn;
    public void active()
    {
        _turn.Turn(inputs.MoveInput());
    }
}