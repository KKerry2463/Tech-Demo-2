using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour, IInteractable
{
    public InventoryItemData referneceItem;
    public void Interact()
    {
        InventorySystem.current.Add(referneceItem);         //calls to add item to inventory system | Also a singleton so it should only exist once!
        Destroy(gameObject);                               //Remove object from scene
    }
}
