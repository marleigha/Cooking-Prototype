using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemClass: ScriptableObject
{
    //data shared across every item!
    public string itemName;
    public string itemID;

    public string itemDescription;
    public Sprite itemIcon;
    public bool isStackable = true;

    public int itemMaxStack;
    // to be used in the subclasses
    public abstract ItemClass GetItem();
    public abstract MiscClass GetMisc();
    public abstract ConsumableClass GetConsumable();
    public abstract ClothingClass GetClothing();
    public abstract FurnitureClass GetFurniture();


}
