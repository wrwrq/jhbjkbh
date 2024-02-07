using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static Inventory;
using static UnityEditor.Progress;
using static UnityEngine.GraphicsBuffer;

public class InventoryPanel : MonoBehaviour
{
    UiManager ie;
    Inventory whoInven;
    Sprite onoffSprite;
    GameObject slotPrefab;
    private void OnEnable()
    {
        ie = UiManager.i;
        SetWorldVariable();
        MakeSlot();
        SlotInIt();
    }
    void SetWorldVariable()
    {
        whoInven = ie.invenSu.inven;
        onoffSprite = ie.invenSu.onoffSprite;
        slotPrefab = ie.invenSu.slot;
    }
    void MakeSlot()
    {
        int a = transform.childCount - whoInven.maxInevntorySize;
        if (a < 0)
        {
            for (int i = 0; i < Mathf.Abs(a); i++)
            {
                GameObject nslot = Instantiate(slotPrefab, this.transform);
                nslot.name = slotPrefab.name;
            }
        }
        else if (a > 0)
        {
            for (int i = 0; i < Mathf.Abs(a); i++)
            {
                Destroy(transform.GetChild(i));
            }
        }
    }
    void SlotInIt()
    {
        for (int i = 0; i < whoInven.ItemCount(); i++)
        {
            GameObject nslot = transform.GetChild(i).gameObject;
            UnityEngine.UI.Image[] slotimage = nslot.GetComponentsInChildren<UnityEngine.UI.Image>();
            Item item = whoInven.AccessItem(i);
            if (item.isEquip == true)
            {
                slotimage[0].sprite = onoffSprite;
            }
            else if (item.isEquip != true)
            {
                slotimage[0].sprite = null;
            }
            slotimage[1].sprite = item.itmeImage;
            nslot.AddComponent<UiPopUp>().t = nslot.GetComponent<UnityEngine.UI.Button>();
            nslot.GetComponent<UiPopUp>().t.onClick.AddListener(ItemIdx);
            ie.invenSu.invenUi = this;
        }
    }
    public void SetSlotImage()
    {
        Item item = whoInven.AccessItem(ie.invenSu.choice);
        if (item.isEquip == true)
        {
            UnityEngine.UI.Image[] slotimage = transform.parent.GetChild(ie.invenSu.choice).GetComponentsInChildren<UnityEngine.UI.Image>();
            slotimage[0].sprite = onoffSprite;
        }
        else if (item.isEquip != true)
        {
            UnityEngine.UI.Image[] slotimage = transform.parent.GetChild(ie.invenSu.choice).GetComponentsInChildren<UnityEngine.UI.Image>();
            slotimage[0].sprite = null;
        }
    }
    public void ItemIdx()
    {
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            if (transform == transform.parent.GetChild(i))
            {
                ie.invenSu.choice = i;
                return;
            }
        }
    }
}
