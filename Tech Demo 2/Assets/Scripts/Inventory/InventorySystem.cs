using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private Dictionary<InventoryItemData, InventoryItem> m_itemDictonary;                  //Create a dictionary. So I can easily grab the reference data.
    public List<InventoryItem> inventory { get; private set; }                               //Create a list variable called inventory with the options of Get & a private set which uses inventory items.
    public static InventorySystem current;                                                  //Part of the singleton.
    private void Awake()                                                                          // When awoken from Inactive.
    {
        inventory = new List<InventoryItem>();                                             //Create a new list for inventory items.
        m_itemDictonary = new Dictionary<InventoryItemData, InventoryItem>();             //Create a new dictionaty for ItemData & Items.
        current = this;                                                                  //Create current inventory system? Singleton is confusing?!?!
       
    }

    public void Add(InventoryItemData referenceData)                                        //Should be called when something is added to inventory
    {
        if (m_itemDictonary.TryGetValue(referenceData, out InventoryItem value))           //Check if item is already within inventory
        {
            value.AddToStack();                                                                   //If it is then add to stack value.
        }
        else                                                                                        //If not then...
        {
            InventoryItem newItem = new InventoryItem(referenceData);                         //Create an instance of the item within the inventory.
            inventory.Add(newItem);                                                          //Add a value to that new item.
            m_itemDictonary.Add(referenceData, newItem);                                    //Add that data & item to the dictionary.
        }
    }
    public void Remove(InventoryItemData referenceData)                                   //Should be called when inventory item is removed from inventory.
    {
        if (m_itemDictonary.TryGetValue(referenceData, out InventoryItem value))         //if the item exists then...
        { 
            value.RemoveFromStack();                                                          //remove from the inventory stack. 
            if (value.stackSize == 0)                                                        //Check if that item has any value in the inventory.
            {
                inventory.Remove(value);                                                    //If not then remove the item from the inventory.
                m_itemDictonary.Remove(referenceData);                                     // & remove the items data from the Dictonary.
            }
        }
    }

    public InventoryItem Get(InventoryItemData referenceData)                         //Called to check if the item exists.
    {
        if (m_itemDictonary.TryGetValue(referenceData, out InventoryItem value))       //Checks if the item exists.
        { 
            return value;                                                                       //Returns with the item.
        }
        return null;                                                                            //Returns null if no item.
    }
}
[Serializable]
public class InventoryItem                                                                  //Instanced version of the Item data
{ 
    public InventoryItemData data { get; private set; }                                   //Pass & set the data into the class
    public int stackSize { get; private set; }                                               //Stack size varible

    public InventoryItem(InventoryItemData source)                                     // new function InventoryItem, takes in the Data and the source.
    { 
        data = source;                                                                       //Sets the source to the inventory item data.
        AddToStack();                                                                       //Call the add to stack function.
    }

    public void AddToStack()                                                               //Function called when something needs to add to the inventory stack.
    {
        stackSize++;                                                                         //Actaully add to stackSize.
    }
    public void RemoveFromStack()                                                         //Function called when something needs to be removed from the inventory stack.
    { 
        stackSize--;                                                                       //Actaully remove from StackSize.
    }
}
