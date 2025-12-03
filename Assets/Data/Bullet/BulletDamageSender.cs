using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageSender : DamageSender
{
    [SerializeField]protected BulletCtrl bulletCtrl;
    [SerializeField] protected DespawnByTime despawnByTime;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBulletCtrl();
        this.LoadDespawnByTime();
    }
    protected virtual void LoadDespawnByTime()
    {
        if (despawnByTime != null) return;
        this.despawnByTime = bulletCtrl.GetComponentInChildren<DespawnByTime>();
    }
    protected virtual void LoadBulletCtrl(){
        if(this.bulletCtrl != null)return;
        this.bulletCtrl = transform.parent.GetComponent<BulletCtrl>();
        Debug.Log(transform.name+":LoadBulletCtrl",gameObject);
    }
    public override void Send(DamageReceiver damageReceiver)
    {
        base.Send(damageReceiver);
        if (this.IsDespawnByTime()) return;
        this.DestroyBullet();
    }
    protected virtual void DestroyBullet(){
        this.bulletCtrl.Despawn.DespawnObject();
    }
    protected virtual bool IsDespawnByTime()
    {
        return this.despawnByTime != null;
    }
    // viet ham bool not laser
}
