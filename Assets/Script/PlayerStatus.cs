using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public static PlayerStatus i;
    public event Action PlayerStatsChange;
    #region PlayerStats
    int level = 1;
    int exp = 2;
    int maxExp = 5;
    int gold = 200;
    int atk = 5;
    int def = 5;
    int hp = 50;
    int criticalDice = 10;
    string nickName = "sk";
    string history = "사람";
    string clas = "백수";
    public int Level { get { return level; } set { level = value; CallPlayerStatsChange(); } }
    public int Exp { get { return exp; } set { exp = value; CallPlayerStatsChange(); } }
    public int MaxExp { get { return maxExp; } set { maxExp = value; CallPlayerStatsChange(); } }
    public int Gold { get { return gold; } set { gold = value; CallPlayerStatsChange(); } }
    public int Atk { get { return atk; } set { atk = value; CallPlayerStatsChange(); } }
    public int Def { get { return def; } set { def = value; CallPlayerStatsChange(); } }
    public int Hp { get { return hp; } set { hp = value; CallPlayerStatsChange(); } }
    public int CriticalDice { get { return criticalDice; } set { criticalDice = value; CallPlayerStatsChange(); } }
    public string NickName { get { return nickName; } set { nickName = value; CallPlayerStatsChange(); } }
    public string History { get { return history; } set { history = value; CallPlayerStatsChange(); } }
    public string Clas { get { return clas; } set { clas = value; CallPlayerStatsChange(); } }
    #endregion
    private void Awake()
    {
        i = this;
        StartCoroutine("wait");
    }
    IEnumerator wait()
    {
        yield return null;
        CallPlayerStatsChange();
    }
    public void CallPlayerStatsChange()
    {
        PlayerStatsChange?.Invoke();
    }
}
