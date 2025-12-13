using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ShootableObject", menuName = "SO/ShootableObject")]
public class ShootableObjectSO : ScriptableObject
{
    public string objName = "Shootable Object";
    public ObjectType objType;
    public int hpMax = 2;
    public int atkDamage = 1;
    public int def = 0;
    public List<ItemDropRate> dropList; // Danh sách các vật phẩm có thể rơi
}
