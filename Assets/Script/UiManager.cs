using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager i;
    [HideInInspector]public InventoryPanelSu invenSu;
    private void Awake()
    {
        i = this;
    }
    private void Start()
    {
        invenSu = GetComponent<InventoryPanelSu>();
    }
    public GameObject GetPopUpUi(string path,Transform t)
    {
        return Instantiate((GameObject)Resources.Load(path), t);
    }
}
