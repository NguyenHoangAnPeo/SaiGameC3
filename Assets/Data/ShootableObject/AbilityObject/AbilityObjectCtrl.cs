using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityObjectCtrl : ShootableObjectCtrl
{
    [Header("Ability Object Ctrl")]
    [SerializeField] protected SpawnPoints spawnPoints;
    [SerializeField] protected Abilities abilities;

    public Abilities Abilities => abilities;
    public SpawnPoints SpawnPoints => spawnPoints;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPoints();
        this.LoadAbilities();
    }
    protected virtual void LoadSpawnPoints()
    {
        if (this.spawnPoints != null) return;
        this.spawnPoints = GetComponentInChildren<SpawnPoints>();
        Debug.Log(transform.name + "LoadSpawnPoints", gameObject);
    }
    protected virtual void LoadAbilities()
    {
        if (this.abilities != null) return;
        this.abilities = GetComponentInChildren<Abilities>();
    }
}
