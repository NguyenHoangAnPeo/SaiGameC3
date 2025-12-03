using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityLaser : BaseAbility
{
    [Header("Laser")]
    [SerializeField] protected Transform spawnLaserPoint;
    [SerializeField] protected BulletSpawner laserSpawner;
    [SerializeField] protected Vector3 shooterPos;
    [SerializeField] protected bool isLasering = false;
    [SerializeField] protected float timeLasering = 0.5f;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnLaser();
    }
    protected virtual void LoadSpawnLaser()
    {
        if (this.spawnLaserPoint != null) return;
        this.spawnLaserPoint = Abilities.AbilityObjectCtrl.SpawnPoints.GetRandom();
    }
    protected override void Update()
    {
        base.Update();
        this.CanShootLaser();
    }
    protected virtual void CanShootLaser()
    {
        if (!isLasering) return;
        this.ShootLaser();
        this.isLasering = false;
    }
    protected virtual Transform ShootLaser()
    {
        if (!this.CanLaser()) return null;
        string laserName = BulletSpawner.laserOne;
        this.shooterPos = spawnLaserPoint.position;
        Transform laserObj = this.laserSpawner.Spawn(laserName, shooterPos, transform.rotation);
        laserObj.gameObject.SetActive(true);
        this.Active();
        return laserObj;
    }
    protected virtual bool CanLaser()
    {
        return isReady;
    }
}
