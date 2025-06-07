using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
  [SerializeField] protected float onFire;
  public float OnFire{get => onFire;}
     [SerializeField] protected Vector3 worldMousePos;
     public Vector3 WorldMousePos {get => worldMousePos;}
  protected static InputManager instance;
  public static InputManager Instance {get => instance;}
  private void Awake(){
    if(InputManager.instance != null){ 
      Debug.Log("Only 1 InputManager is exits");
    }
    InputManager.instance = this;
  }
  void Update()
  {
    this.GetMouseDown();
  }
  void FixedUpdate()
     {
      this.GetMousePos();
     }
 protected virtual void GetMousePos(){
     this.worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 }
 protected virtual void GetMouseDown()
 {
  this.onFire = Input.GetAxis("Fire1");
 }

}
