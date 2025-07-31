using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectal : MonoBehaviour
{
    [SerializeField] GameObject FireBallPrefab;
    [SerializeField] GameObject IblastPrefab;
    [SerializeField] GameObject Particle;
    [SerializeField] Transform ShootPosition;

    public Bullet CreateFireBall()
    {
        GameObject fireBall = Instantiate(FireBallPrefab, ShootPosition.position, ShootPosition.rotation);
        return fireBall.GetComponent<Bullet>();
    }

    public Bullet CreateIBlast()
    {
        GameObject iblast = Instantiate(IblastPrefab, ShootPosition.position, ShootPosition.rotation);
        return iblast.GetComponent<Bullet>();
    }    
    
    public Bullet CreateParticle()
    {
        GameObject particle = Instantiate(Particle, ShootPosition.position, ShootPosition.rotation);
        return particle.GetComponent<Bullet>();
    }
}
