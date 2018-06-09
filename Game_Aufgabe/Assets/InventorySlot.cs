using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {
    public Text ItemName;
    Item item;
    public void AddItem(Item newitem)
    {
        item = newitem;
        ItemName.text = item.name;
        ItemName.enabled = true;
    }
    public void ClearItem()
    {
        item = null;
        ItemName.text = null;
        ItemName.enabled = false;
      
    }
        
}
