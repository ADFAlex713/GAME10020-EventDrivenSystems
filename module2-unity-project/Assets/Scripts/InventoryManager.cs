using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventoryManager : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent OnInventoryChanged;

    public Dictionary<InventoryItem, int> inventory = new Dictionary<InventoryItem, int>();

    public void Awake()
    {
        if (OnInventoryChanged == null) OnInventoryChanged = new UnityEvent();

        // important step:
        // initialize all of the inventory item keys
        inventory[InventoryItem.Pumpkin] = 0;
        inventory[InventoryItem.Lantern] = 0;
        inventory[InventoryItem.Coffin] = 0;
    }

    public void PickUpInventory(InventoryItem item)
    {
        inventory[item] += 1;
    }    
    
    public void DropInventory(InventoryItem item)
    {
        // the key is guaranteed to exist here
        inventory[item] -= 1;
    }
}
