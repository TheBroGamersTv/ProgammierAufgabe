using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Transform InventoryParent;
    List<Item> item = new List<Item>();
    InventorySlot[] slot;
    // Use this for initialization
    void Start()
    {
        slot = InventoryParent.GetComponentsInChildren<InventorySlot>();
        for (int i = 0; i < slot.Length; i++)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void AddItem(Item newItem)
    {
        for (int i = 0; i < slot.Length; i++)
        {
            if (slot[i] == null)
            {

            }
        }
    }
    void UpdateUI()
    {
       
    }
}
