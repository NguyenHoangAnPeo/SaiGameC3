using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : AnMonoBehaviour
{
    [Header("Abilities")]
    [SerializeField] protected AbilityObjectCtrl abilityObjectCtrl;
    public AbilityObjectCtrl AbilityObjectCtrl => abilityObjectCtrl;

    [SerializeField] protected AbilityLaserFromInput abilityLaser;
    public AbilityLaserFromInput AbilityLaserFromInput => abilityLaser;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAbilityObjCtrl();
        this.LoadAbilityLaser();
    }
    protected virtual void LoadAbilityLaser()
    {
        if (this.abilityLaser != null) return;
        this.abilityLaser = transform.GetComponentInChildren<AbilityLaserFromInput>();
    }
    protected virtual void LoadAbilityObjCtrl()
    {
        if (this.abilityObjectCtrl != null) return;
        this.abilityObjectCtrl = transform.parent.GetComponent<AbilityObjectCtrl>();
        Debug.Log(transform.name + "LoadAbilityObjCtrl", gameObject);
    }
}
