using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class panel : MonoBehaviour
{
    UiManager ie;
    Inventory whoInven;
    private void OnEnable()
    {
        ie = UiManager.i;
        whoInven = ie.invenSu.inven;
        if (whoInven.transform.gameObject.GetComponent<PlayerStatus>() != null)
        {
            CasePlayer();
        }
        GetComponentsInChildren<Button>()[1].onClick.AddListener(De);
    }
    void CasePlayer()
    {
        if (whoInven.AccessItem(ie.invenSu.choice).isEquip)
        {
            GetComponentInChildren<Text>().text = "장비를 해제 하시겠습니까?";
        }
        else
        {
            GetComponentInChildren<Text>().text = "장비를 착용 하시겠습니까?";
        }
    }
    void CaseShop()
    {

    }
    void De()
    {
        whoInven.AccessItem(ie.invenSu.choice).isEquip = !whoInven.AccessItem(ie.invenSu.choice).isEquip;
        ie.invenSu.invenUi.SetSlotImage();
        Destroy(gameObject);
    }
}
