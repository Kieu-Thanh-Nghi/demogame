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

    bool isJump;
    public bool JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
            StopCoroutine(waitAJump());
            StartCoroutine(waitAJump());
            return isJump;
        }
        return isJump;
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

    IEnumerator waitAJump()
    {
        var wait = new WaitForSeconds(0.25f);
        yield return wait;
        isJump = false;
    }
}
