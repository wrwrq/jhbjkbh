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
            GetComponentInChildren<Text>().text = "��� ���� �Ͻðڽ��ϱ�?";
        }
        else
        {
            GetComponentInChildren<Text>().text = "��� ���� �Ͻðڽ��ϱ�?";
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
