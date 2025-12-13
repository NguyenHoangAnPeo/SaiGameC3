using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : PlayerAbstract
{
    [Header("Base stats")]
    [SerializeField] protected float baseHp;
    public float BaseHP => baseHp;
    [Header("Final stats")]
    [SerializeField] protected float finalHp;
    public float FinalHP => finalHp;
    protected override void Start()
    {
        base.Start();
        this.LoadStatsPlayer();
    }
    protected virtual void LoadStatsPlayer()
    {
        this.baseHp = PlayerCtrl.CurrentShip.DamageReceiver.HPMax;
    }
    public void RecalculateStats(ItemProFileSO equipment)
    {
        this.finalHp = this.baseHp;
        if (equipment != null)
        {
            finalHp += equipment.equipmentStats.bonusHP;
        }
    }
}
