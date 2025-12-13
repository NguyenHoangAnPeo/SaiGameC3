using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : AnMonoBehaviour
{
    public static EquipmentManager Instance;
    [SerializeField] protected ItemProFileSO equipmentSO;
    public ItemProFileSO EquipmentSO => equipmentSO;

    [SerializeField] protected PlayerStats playerStats;
    public PlayerStats PlayerStats => playerStats;

    protected override void Awake()
    {
        base.Awake();
        if (EquipmentManager.Instance != null) return;
        Instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerStats();
    }
    protected virtual void LoadPlayerStats()
    {
        if (this.playerStats != null) return;
        this.playerStats = FindObjectOfType<PlayerStats>();
    }
    public void Equip(ItemProFileSO equipment)
    {
        if(equipment.itemType == ItemType.Equiment)
        {
            this.equipmentSO = equipment;
        }
        PlayerStats.RecalculateStats(equipmentSO);
    }
}
