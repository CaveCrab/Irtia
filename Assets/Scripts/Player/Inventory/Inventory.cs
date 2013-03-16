using UnityEngine;
using System.Collections;

//Inventory class, holding all inventory-related stuff like adding, deleting and updating items.

public class Inventory : MonoBehaviour
{
	public Item[] inventory;
	public Texture[] images;
	public bool update;
	public int inventorysize,itemnumber; //inventory size and item numbers
	
	void Start()
	{
		update = false;
		inventory = new Item[inventorysize];
		images = new Texture[inventorysize];
	}
	public void Add(Item item) // a function for adding items, takes an item and adds it to the inventory item list
	{
		inventory[itemnumber] = item;
		item.number = itemnumber;
		update = true;
		itemnumber++; 
	}
	public void UpdateImages() // updates the item image list based on the inventory item list
	{
		foreach(Item item in inventory)
		{
			if(item != null)
			{
				images[item.number]  = item.image;	
			}
		}
	}
}
