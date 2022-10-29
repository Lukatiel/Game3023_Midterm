using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemySystem : MonoBehaviour
{
    public Button BrewButton, InventoryButton, MakePotionButton;
    public GameObject Inventory, Alchemy;

    [SerializeField]
    Recipes Recipe;

    
    [SerializeField, Tooltip("List of the item slots needed")]
    List<ItemSlot> InputSlots = new List<ItemSlot>();

    public ItemSlot OutputSlot;

    

    public void BrewButtonClicked()
    {
        Inventory.SetActive(false);
        Alchemy.SetActive(true);
    }

    public void InventoryButtonClicked()
    {
        Inventory.SetActive(true);
        Alchemy.SetActive(false);
    }

    public void CraftButtonClicked()
    {
        for (int i = 0; i < Inventory.GetComponent<Inventory>().itemSlots.Count; i++)
        {
            if(Inventory.GetComponent<Inventory>().itemSlots[i].item == null)
            {
                Inventory.GetComponent<Inventory>().itemSlots[i].AddItemToSlot(Recipe.RecipeOutput, 1);
                Debug.Log("Item added to slot");
                break;
            }
        }
        
        


    }

    
    
    //  Add the crafted item to a new item slot and update the count to 1

}
