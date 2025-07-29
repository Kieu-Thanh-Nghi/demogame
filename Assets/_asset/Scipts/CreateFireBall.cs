using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFireBall : MonoBehaviour
{
    [SerializeField] GameObject FireBallPrefab;
    [SerializeField] Transform ShootPosition;

    public Bullet Shoot()
    {
        GameObject fireBall = Instantiate(FireBallPrefab, ShootPosition.position, ShootPosition.localRotation);
        return fireBall.GetComponent<Bullet>();
    }
}
