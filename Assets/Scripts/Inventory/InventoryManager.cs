using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] public GameObject slotHolder;
    [SerializeField] private ItemClass itemToAdd;
    [SerializeField] private ItemClass itemToRemove;
    //public List<ItemClass> inventoryItems = new List<ItemClass>();
    public List<SlotClass> inventoryItems = new List<SlotClass>();
    // working on the new video three
    //public SlotClass[] inventoryItems;
    private GameObject[] slots;
    public void Start()
    {
        //establish all the slots in the Slot holder
        slots = new GameObject[slotHolder.transform.childCount];
        // commented out bc it's from the new video lol
        //inventoryItems = new SlotClass[slots.Length];

        //establish all the slots in the Slot holder
        for (int i = 0; i < slotHolder.transform.childCount; i++)
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        RefreshUI();
        AddToInventory(itemToAdd);
        RemoveFromInventory(itemToRemove);
    }

    public void RefreshUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            try
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = inventoryItems[i].GetItem().itemIcon;
                if (inventoryItems[i].GetItem().isStackable)
                {
                    slots[i].transform.GetChild(1).GetComponent<TMP_Text>().text = inventoryItems[i].GetQuantity().ToString();
                }
                else
                {
                    slots[i].transform.GetChild(1).GetComponent<TMP_Text>().text = "";
                }
            }
            catch
            {
                //there's no item there
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                slots[i].transform.GetChild(1).GetComponent<TMP_Text>().text = "";
            }
        }

    }

    public bool AddToInventory(ItemClass item)
    {
        SlotClass slot = Contains(item);
        //check if inventory contains the item!
        if (slot != null && slot.GetItem().isStackable && (slot.GetQuantity() < slot.GetItem().itemMaxStack))
        {
            slot.AddQuanity(1);
            Debug.Log(item.itemName + "was succesfully stacked in our Inventory");
        }
        else
        {
            if(inventoryItems.Count < slots.Length)
            {
                inventoryItems.Add(new SlotClass(item, 1));
                Debug.Log(item.itemName + "was succesfully added to Inventory");
            }
            else{ return false;}
        }
        RefreshUI();
        return true;
    }

    public bool RemoveFromInventory(ItemClass item)
    {
        SlotClass temp = Contains(item);
        if (temp != null)
        {
            if (temp.GetQuantity() > 1)
            {
                temp.SubQuanity(1);
                Debug.Log(item.itemName + "was succesfully subtracted from our Inventory");
                //return true;
            }
            else
            {
                SlotClass slotToRemove = new SlotClass();
                foreach (SlotClass slot in inventoryItems)
                {
                    if (slot.GetItem() == item)
                    {
                        slotToRemove = slot;
                        break;
                    }
                }
                inventoryItems.Remove(slotToRemove);
                Debug.Log(item.itemName + "was succesfully removed from Inventory");
            }
        }
        else{return false;}
            RefreshUI();
            return true;
        }

        public SlotClass Contains(ItemClass item)
        {
            foreach (SlotClass slot in inventoryItems)
            {
                if (slot.GetItem() == item)
                {
                    return slot;
                }
            }
            return null;
        }
    }
