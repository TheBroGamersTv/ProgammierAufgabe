using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    public static Inventory instance;//to make possible so other scripts can access this instance(the way to do this is called Singleton)
    public int MaxSpace = 15;
    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
        }
        instance = this;
    }
    #endregion
    public List<Item> items = new List<Item>();

    public bool Add(Item item)
    {
        if(items.Count >= MaxSpace)
        {
            Debug.LogWarning("Not enough room in Inventory!");//Self explaining :)

            return false;
        }
        items.Add(item);
        if (onItemChangedCallback != null)//to Update UI ---- it gets activated when an Item gets added
        {
            onItemChangedCallback.Invoke();
        }
        
        return true;
    }
    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }










    /* public Transform InventoryParent;
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

     }*/
}
