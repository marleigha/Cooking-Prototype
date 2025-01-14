using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "new Misc Class", menuName = "Item/Misc")]
public class MiscClass : ItemClass
{
    //data specific to MiscClass
    public override ItemClass GetItem() {return this;}
    //Since this is a consumable and not a Misc Item, it will return null!
    public override MiscClass GetMisc() {return this;}
    public override ConsumableClass GetConsumable() {return null;}
        public override FurnitureClass GetFurniture() {return null;}
    public override ClothingClass GetClothing() {return null;}
}
