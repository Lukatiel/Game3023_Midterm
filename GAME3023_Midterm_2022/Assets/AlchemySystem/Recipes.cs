using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe/New Recipe")]
public class Recipes : ScriptableObject
{
    [SerializeField, Tooltip("The items that will be used to create the potion")]
    public List<Item> ItemInputs = new List<Item>();

    [SerializeField, Tooltip("The item that will be created")]
    public Item RecipeOutput;
}
