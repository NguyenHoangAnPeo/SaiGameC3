using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float disLimit = 50f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Transform mainCamera;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }
    protected override void FixedUpdate(){
        this.Despawning();
    }
    protected virtual void LoadCamera(){
        if(this.mainCamera != null)return;
        this.mainCamera = Transform.FindObjectOfType<Camera>().transform;
    }
    protected override bool CanDespawn(){
        this.distance = Vector3.Distance(this.transform.position,this.mainCamera.position);
        if(this.distance > disLimit)return true;
        return false;
    }
}
