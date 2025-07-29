using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSprite : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    public void Turn(float direct)
    {
        if (direct < -0.1)
        {
            spriteRenderer.flipX = true;
        }
        else if (direct > 0.1)
        {
            spriteRenderer.flipX = false;
        }
    }
}
