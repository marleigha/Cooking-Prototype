using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Furniture Class", menuName = "Item/Furniture")]
public class FurnitureClass : ItemClass
{
    [Header("Furniture")]
    public float sellPrice;
    public float buyPrice;
    //public enum FurnitureType { }
    public override ItemClass GetItem() {return this;}
    //Since this is a consumable and not a Misc Item, it will return null!
    public override MiscClass GetMisc() {return null;}
    public override ConsumableClass GetConsumable() {return null;}
    public override FurnitureClass GetFurniture() {return this;}
    public override ClothingClass GetClothing() {return null;}
}
