using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BtnSetActiveObj : BaseBtn
{
    [SerializeField] public GameObject Object;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadGameObject();
    }
    protected override void OnClick()
    {
        this.Interact();
    }
    protected abstract void Interact();
    protected abstract void LoadGameObject();
}
