using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "new Consumable Class", menuName = "Item/Consumable")]
public class ConsumableClass : ItemClass
{
    [Header("Consumable")]
// data specific to the consumable class
    public float sellPrice;
    public float buyPrice;

    public ConsumableType consumabletype;
    public enum ConsumableType
    {
        sweet,
        spicy,
        tangy,
        tart,
        earthy

    }

    public override ItemClass GetItem() {return this;}
    //Since this is a consumable and not a Misc Item, it will return null!
    public override MiscClass GetMisc() {return null;}
    public override ConsumableClass GetConsumable() {return this;}
    public override FurnitureClass GetFurniture() {return null;}
    public override ClothingClass GetClothing() {return null;}
}
