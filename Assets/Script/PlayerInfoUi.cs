using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUi : MonoBehaviour
{
    PlayerStatus p;
    [SerializeField] Text goldText;
    [SerializeField] Text nickNameText;
    [SerializeField] Text LvText;
    [SerializeField] GameObject ExpObj;
    [SerializeField] Text clas;
    [SerializeField] Text histroyText;
    private void Start()
    {
        p = PlayerStatus.i;
        p.PlayerStatsChange += ChangeUi;
    }
    void ChangeUi()
    {
        goldText.text = p.Gold.ToString();
        nickNameText.text = p.NickName;
        LvText.text = "Lv " + p.Level.ToString();
        ExpObj.GetComponentInChildren<Text>().text = $"{p.Exp} / {p.MaxExp}";
        ExpObj.GetComponent<Slider>().value = p.Exp / (float)p.MaxExp;
        clas.text = p.Clas;
        histroyText.text = p.History;
    }
}
