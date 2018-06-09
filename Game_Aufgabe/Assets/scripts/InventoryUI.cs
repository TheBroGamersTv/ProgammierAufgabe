﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    InventorySlot[] slots;
    Inventory inventory;
    // Use this for initialization
    void Start()
    {
        inventory = Inventory.instance;//Defining inventory with the Singleton from Inventory
        inventory.onItemChangedCallback += UpdateUI;//Whenever an Item gets Added it updates
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();   
    }

    // Update is called once per frame
    void Update()
    {

    }
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
        Debug.Log("update UI");
    }
        
}
