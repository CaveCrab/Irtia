using UnityEngine;
using System.Collections;

//Inventory class, holding all inventory-related stuff like adding, deleting and updating items.

public class Inventory : MonoBehaviour
{
	public Item[] inventory;//Item list (=inventory)
	public Texture[] itemimages;//item image list for inventory rendering
	public int itemnumber,imagenumber,inventorysize;//item and image numbers for list placeholding and the base size for the inventory
	public bool update;//a boolean for updating the inventory image list
	void Start()
	{
		update = false;
		inventory = new Item[inventorysize];//set the inventory
		itemimages = new Texture[inventorysize];//set the item image list
		itemnumber = 0; //reset the place numbers
		imagenumber = 0;
	}
	public void Add(Item item) // a function for adding items, takes an item
	{
		inventory[itemnumber] = item;
		item.number = itemnumber;
		update = true;
		itemnumber++; 
	}
	public void UpdateImages() // updates the item image list based on the inventory item list
	{
		if(update == true)
		{
			int i = 0;
			while(i < inventorysize)
			{
				if(inventory[i] == null)
				{
				 	itemimages[i] = null; 
					i++;
				}
				else
				{
					itemimages[i] = inventory[i].image;
					i++;
				}
				
			}
			update = false; 
		}
	}
}
