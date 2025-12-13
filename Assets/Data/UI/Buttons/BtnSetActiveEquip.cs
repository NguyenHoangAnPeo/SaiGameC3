using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSetActiveEquip : BtnSetActiveObj
{

    protected override void LoadComponents()
    {
        base.LoadComponents();
    }
    protected override void LoadGameObject()
    {
        if (this.Object != null) return;
        this.Object = transform.Find("Equip")?.gameObject;
    }
    protected override void Interact()
    {
        if (this.Object == null) return;
        this.Object.SetActive(!this.Object.activeSelf);
        Debug.Log("Da chay ham on click");
    }
}
