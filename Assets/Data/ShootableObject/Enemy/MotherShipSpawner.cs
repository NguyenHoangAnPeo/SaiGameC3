using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShipSpawner : Spawner
{
   [SerializeField] protected static MotherShipSpawner instance;
   [SerializeField] public static MotherShipSpawner Instance{get => instance;}
    protected override void Awake()
    {
        base.Awake();
         if(MotherShipSpawner.instance != null)Debug.Log("Only 1 MotherShipSpawner is exits");
        MotherShipSpawner.instance = this;
    }
    public override Transform Spawn(Transform prefab, Vector2 spawnPos, Quaternion rotation)
    {
        Transform newMotherShip =  base.Spawn(prefab, spawnPos, rotation);
        this.AddHPBarToObj(newMotherShip);
        return newMotherShip;
    }
    protected virtual void AddHPBarToObj(Transform newEnemy)
    {
        ShootableObjectCtrl newEnemyCtrl = newEnemy.GetComponent<ShootableObjectCtrl>();
        Transform newHpBar = HPBarSpawner.Instance.Spawn(HPBarSpawner.HPBarMotherShip, newEnemy.position, Quaternion.identity);
        HPBar hpBar = newHpBar.GetComponent<HPBar>();
        hpBar.SetObjectCtrl(newEnemyCtrl);
        hpBar.SetFollowTarget(newEnemy);

        newHpBar.gameObject.SetActive(true);
    }
}
