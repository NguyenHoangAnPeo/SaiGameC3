using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityLaserFromInput : AbilityLaser
{
    protected override void Update()
    {
        base.Update();
        this.GetKey1Down();
    }
    protected virtual void GetKey1Down()
    {
        if (InputHotKeyManager.Instance.isAlpha1) isLasering = true;
        return;
    }
}
