using UnityEngine;
using System.Collections;

//Example script for lootable objects

public class Loot : MonoBehaviour
{
	Item item; //The item attached to this lootable object
	
	void Start ()
	{
		item = GetComponent<Item>(); //Look for the item in the same gameobject
	}
	
	void OnCollisionEnter(Collision collision) //On collision, if the collider is tagged player, add the item to the inventory and self-destruct
	{
		if(collision.gameObject.tag == "player")
		{
			collision.gameObject.GetComponent<Inventory>().Add(item);
			Destroy(gameObject);
		}
	}
}
