using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    public bool DownInput()
    {
        return Input.GetKey(KeyCode.S);
    }
    public float MoveInput()
    {
        return Input.GetAxis("Horizontal");
    }

    DelayTemp DelayisJump = new();
    public bool JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return true;
        }
        else
        {
            return DelayisJump.value;
        }
    }
    WaitForSeconds wait = new WaitForSeconds(0.25f);
    public void JumpInputDelay()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine("DelayInput");
            DelayisJump.value = false;
            StartCoroutine(DelayInput(DelayisJump, wait));
        }
    }

    IEnumerator DelayInput(DelayTemp _a, WaitForSeconds wait)
    {
        _a.value = true;
        yield return wait;
        _a.value = false;
    }

    internal bool AttackInput()
    {
        return Input.GetKeyDown(KeyCode.J);
    }

    internal bool StrikeInput()
    {
        return Input.GetKeyDown(KeyCode.K);
    }

    internal bool FlyKickInput()
    {
        return Input.GetKeyDown(KeyCode.L);
    } 
}

class DelayTemp{
    public bool value;
}
