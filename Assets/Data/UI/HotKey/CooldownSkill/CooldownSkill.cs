using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CooldownSkill : AnMonoBehaviour
{
    [SerializeField] protected ShipCtrl shipCtrl;
    public ShipCtrl ShipCtrl => shipCtrl;
    [SerializeField] protected PlayerCtrl playerCtrl;
    public PlayerCtrl PlayerCtrl => playerCtrl;

    [SerializeField] protected Abilities abilities;
    public Abilities Abilities => abilities;

    [SerializeField] protected Image image;
    public Image Image => image;
    [SerializeField] protected float cooldownTime;
    [SerializeField] protected float maxTime;
    protected virtual void Update()
    {
        this.UpdateCooldown();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
        this.LoadShipCtrl();
        this.LoadAbilities();
        this.LoadImage();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        GameObject playerCtrl = GameObject.Find("PlayerCtrl");
        this.playerCtrl = playerCtrl.GetComponent<PlayerCtrl>();
    }
    protected virtual void LoadShipCtrl()
    {
        if (this.shipCtrl != null) return;

        this.shipCtrl = this.playerCtrl.CurrentShip;
    }

    protected virtual void LoadAbilities()
    {
        this.LoadShipCtrl();
        if (this.abilities != null) return;
        this.abilities = this.ShipCtrl.GetComponentInChildren<Abilities>();
    }
    protected virtual void LoadImage()
    {
        if (this.image != null) return;
        this.image = GetComponent<Image>();
    }
    protected abstract void UpdateCooldown();
}
