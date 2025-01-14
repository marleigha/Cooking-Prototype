using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SlotClass
{
   // this is here to store data
   [SerializeField] private ItemClass item;
   [SerializeField] private int quantity;

//empty slot class
public SlotClass()
{
    item = null;
    quantity = 0;
}
// the constructor!
   public SlotClass(ItemClass _item, int _quantity)
   {
    item = _item;
    quantity = _quantity;
   }

   public ItemClass GetItem(){return item;}
   public int GetQuantity(){return quantity;}
   public void SetQuantity(int newQuantity){quantity = newQuantity;}
   public void AddQuanity(int quanityToAdd){quantity += quanityToAdd;}
   public void SubQuanity(int quanityToSub){quantity -= quanityToSub;}
}
