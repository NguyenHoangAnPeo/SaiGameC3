using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : AnMonoBehaviour
{
    [SerializeField] protected DamageSender damageSender;
    public DamageSender DamageSender { get => damageSender; }
    [SerializeField] protected Despawn despawn;
    [SerializeField] public Despawn Despawn { get => despawn; }
    [SerializeField] protected Transform shooter;
    public Transform Shooter => shooter;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDamageSender();
        this.LoadBulletDespawn();
    }
    protected virtual void LoadDamageSender()
    {
        if (this.damageSender != null) return;
        this.damageSender = GetComponentInChildren<DamageSender>();
    }
    protected virtual void LoadBulletDespawn()
    {
        if (this.despawn != null) return;
        this.despawn = GetComponentInChildren<Despawn>();
        Debug.Log(transform.name + ": LoadBulletDespawn", gameObject);
    }
    public virtual void SetShooter(Transform shooter)
    {
        this.shooter = shooter;
    }
}
