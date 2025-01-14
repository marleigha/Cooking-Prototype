using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Clothing Class", menuName = "Item/Clothing")]
public class ClothingClass : ItemClass
{
    
    [Header("Clothing")]

    public float buyPrice;
    public enum ClothingType
    {
        top,
        bottom,
        shoes,
        overalls,
        hat


    }
    public override ItemClass GetItem() {return this;}
    //Since this is a consumable and not a Misc Item, it will return null!
    public override MiscClass GetMisc() {return null;}
    public override ConsumableClass GetConsumable() {return null;}
    public override FurnitureClass GetFurniture() {return null;}
    public override ClothingClass GetClothing() {return this;}
}
