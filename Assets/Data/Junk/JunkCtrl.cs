using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : AnMonoBehaviour
{
    [SerializeField]protected JunkDespawn junkDespawn;
    [SerializeField]public JunkDespawn JunkDespawn{get=>junkDespawn;}
    [SerializeField] protected Transform model;
    public Transform Model {get=> model;}
    protected override void LoadComponents(){
        base.LoadComponents();
        this.LoadModel();
        this.LoadJunkDespawn();
    }
    protected virtual void LoadJunkDespawn(){
         if(this.junkDespawn != null)return;
        this.junkDespawn = GetComponentInChildren<JunkDespawn>();
        Debug.Log(transform.name+ "LoadjunkDespawn",gameObject);
    }
    protected virtual void LoadModel(){
        if(this.model != null)return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name+ "LoadModel",gameObject);

    }
}
