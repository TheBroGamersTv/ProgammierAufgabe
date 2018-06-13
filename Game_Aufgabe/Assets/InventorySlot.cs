using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {
    public Text ItemName;
    Item item;
    public Button removeButton;
    public void AddItem(Item newitem)
    {
        item = newitem;
        ItemName.text = newitem.name;
        ItemName.enabled = true;
        removeButton.interactable = true;//damit falls ein Item da ist um es zu entfernen zu lönnen mit dem button
    }
    public void ClearItem()
    {
        item = null;
        ItemName.text = null;
        ItemName.enabled = false;
        removeButton.interactable = false;//Das gegenteil von vorher
      
    }
    public void OnRemoveButton()//Damit der Removebutton auch was macht
    {
        Inventory.instance.Remove(item);
    }
    public void UseItem()//um das Item benutzen zu können 
    {
        item = null;
        ItemName.text = null;
        ItemName.enabled = false;
        removeButton.interactable = false;
        if (item != null)
        {
            item.Use();
        }
    }
}
