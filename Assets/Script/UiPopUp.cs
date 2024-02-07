using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UiPopUp : MonoBehaviour
{
    public UnityEngine.UI.Button t;
    UnityEngine.UI.Button tt;
    GameObject targetUi;
    private void Start()
    {
        t.onClick.AddListener(PopUpUi);
    }
    public void PopUpUi()
    {
        targetUi = UiManager.i.GetPopUpUi(name, FindObjectOfType<Canvas>().transform);
        tt = targetUi.GetComponentInChildren<UnityEngine.UI.Button>();
        tt.onClick.AddListener(CloseUi);
    }
    public void CloseUi()
    {
        Destroy(targetUi);
    }
}
