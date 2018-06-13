using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{ //you can add various variables, what the Item will do depends on it's name
    new public string name = "New Item";//Because theres a name in Unity already we're going to override it with "new"

    public int Amount = 80;
    public bool isDefaultItem = false;

    public virtual void Use()//Because different Items have different abilites(virtual)
    {
        Debug.Log("Using" + name);
    }
}
