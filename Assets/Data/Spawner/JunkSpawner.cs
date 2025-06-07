using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
   [SerializeField] protected static JunkSpawner instance;
   [SerializeField] public static JunkSpawner Instance{get => instance;}
   public static string meteoriteOne = "Meteorite_1";
    protected override void Awake()
    {
        base.Awake();
         if(JunkSpawner.instance != null)Debug.Log("Only 1 JunkSpawner is exits");
        JunkSpawner.instance = this;
    }

}
