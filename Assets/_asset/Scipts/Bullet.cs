using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float FlySpeed;
    [SerializeField] float LifeTime;

    private void Start()
    {
        StartCoroutine(WaitToDestroy());
    }

    private void FixedUpdate()
    {
        transform.Translate(transform.right * FlySpeed * Time.fixedDeltaTime, Space.World);
    }

    public void SetUpFlySpeed(float newSpeed)
    {
        FlySpeed = newSpeed;
    }

    public void SetUpLifeTime(float newLifeTime)
    {
        LifeTime = newLifeTime;
        StopCoroutine(WaitToDestroy());
        StartCoroutine(WaitToDestroy());
    }

    IEnumerator WaitToDestroy()
    {
        var wait = new WaitForSeconds(LifeTime);
        yield return wait;
        Destroy(this.gameObject);
    }
}
