using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPanel : MonoBehaviour
{
    PlayerStatus p;
    [SerializeField] Text atk;
    [SerializeField] Text def;
    [SerializeField] Text hp;
    [SerializeField] Text ciriticalDice;

    private void OnEnable()
    {
        p = PlayerStatus.i;
        atk.text = p.Atk.ToString();
        def.text = p.Def.ToString();
        hp.text = p.Hp.ToString();
        ciriticalDice.text = p.CriticalDice.ToString();
    }
}
