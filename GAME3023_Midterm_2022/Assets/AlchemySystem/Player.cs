using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Dictionary<string, int> PlayerStat = new Dictionary<string, int>();

    public TMP_Text Str_Amount;
    public TMP_Text Dex_Amount;
    public TMP_Text Int_Amount;
    public TMP_Text Def_Amount;
    public TMP_Text Sta_Amount;

    private void Start()
    {
        PlayerStat.Add("strength", 5);
        PlayerStat.Add("dexterity", 5);
        PlayerStat.Add("intelligence", 5);
        PlayerStat.Add("defense", 5);
        PlayerStat.Add("stamina", 5);

        //foreach (string key in PlayerStat.Keys)
        //{
        //    Debug.Log("Player Stat " + key + " has a value of " + PlayerStat[key]);
        //}
    }

    private void Update()
    {
        Str_Amount.SetText(PlayerStat["strength"].ToString());
        Dex_Amount.SetText(PlayerStat["dexterity"].ToString());
        Int_Amount.SetText(PlayerStat["intelligence"].ToString());
        Def_Amount.SetText(PlayerStat["defense"].ToString());
        Sta_Amount.SetText(PlayerStat["stamina"].ToString());


        //foreach (string key in PlayerStat.Keys)
        //{
        //    Debug.Log("Player Stat " + key + " has a value of " + PlayerStat[key]);
        //}
    }

    

    
}
