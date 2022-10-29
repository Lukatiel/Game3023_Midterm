using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item Effect", menuName = "Items/New Effect")]
public class ItemEffects : ScriptableObject
{
    
    public string EffectName = "";

    [Tooltip("This is the stat the item will effect. Use lower case letters only")]
    public string Stat = "";

    [SerializeField, Tooltip("This is the amount the player's stat will be effected by, use a negative number if you want to decrease the stat")]
    public int Amount = 0;


    //Need to figure out stat to effect
    //How much to affect it by
}
