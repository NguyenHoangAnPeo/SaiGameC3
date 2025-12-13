using UnityEngine;


public class BtnEquip : BaseBtn
{
    [SerializeField] protected RectTransform equipSlot;

    [SerializeField] protected RectTransform itemRoot;

    [SerializeField] protected UIItemInventory uIItemInventory;
    public UIItemInventory UIItemInventory => uIItemInventory;

    protected override void Awake()
    {
        base.Awake();
        itemRoot = GetComponentInParent<UIItemInventory>().GetComponent<RectTransform>();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadUIItemInvent();
        this.LoadSlot();
    }
    protected virtual void LoadUIItemInvent()
    {
        if (this.uIItemInventory != null) return;
        this.uIItemInventory = transform.GetComponentInParent<UIItemInventory>();
    }
    protected virtual void LoadSlot()
    {
        if (this.equipSlot != null) return;
        this.equipSlot = GameObject.Find("EquipSlot")?.transform.GetComponent<RectTransform>();
    }

    protected override void OnClick()
    {
        this.EquipItem();
    }

    protected virtual void EquipItem()
    {
        if (equipSlot == null || itemRoot == null) return;

        itemRoot.SetParent(equipSlot, false);
        itemRoot.anchoredPosition = new Vector2(35f, -25f);
        itemRoot.localScale = Vector3.one;

        Inventory.Instance.DeductItem(uIItemInventory.ItemInventory.itemProfile.itemCode, 1);
    }
}
