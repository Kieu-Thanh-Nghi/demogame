using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStateActions : MonoBehaviour
{
    [SerializeField] InputControl inputs;
    [SerializeField] PlayerPhysic physic;
    [SerializeField] Move _move;
    [SerializeField] TurnSprite _turn;
    [SerializeField] Jump _jump;

    private void Reset()
    {
        GameObject _player = gameObject;
        inputs = _player.GetComponent<InputControl>();
        physic = _player.GetComponent<PlayerPhysic>();
        _move = _player.GetComponent<Move>();
        _turn = _player.GetComponent<TurnSprite>();
        _jump = _player.GetComponent<Jump>();
    }

    public void MoveProcess()
    {
        float direct = inputs.MoveInput();
        _move.Going(direct);
        _turn.Turn(direct);
    }

    public void JumpProcess()
    {
        if (!physic.isUp && inputs.JumpInput())
        {
            if(physic.isGround) _jump.JumpUp();
        }
    }

    internal void CrouchTurn()
    {
        _turn.Turn(inputs.MoveInput());
    }
}
