using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CooldownSkillLaser : CooldownSkill
{
    protected override void UpdateCooldown()
    {
        this.cooldownTime = abilities.AbilityLaserFromInput.TimerCooldown;
        this.maxTime = abilities.AbilityLaserFromInput.TimerDelay;
        image.fillAmount =  cooldownTime / maxTime;

    }
}
