using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {
    public Text ItemName;
    public Item item;
    public void AddItem(Item newitem)
    {
        item = newitem;
        ItemName = item.Name;
    }
    public void ClearItem()
    {
        item = null;
        ItemName = null;
      
    }
        
}
