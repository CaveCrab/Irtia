using UnityEngine;
using System.Collections;

//Player HUD

public class HUD : MonoBehaviour
{
	//Inventory item image list
	public Texture[] itemimages;
	//Health bar textures
	public Texture2D healthbar_empty;
	public Texture2D healthbar_full;
	// Health bar coordinates
	Rect hud;
	int height;
	int width;
	//Player object
	GameObject player;
	//Bool for showing the inventory
	public bool showinventory;
	//Inventory selected item. -1 if nothing is selected
	public int selected;
	
	void Start ()
	{
		selected = -1;
		showinventory = false;
		width = Screen.width;
		height = Screen.height;
		hud = new Rect(height/32,height/32,width/2-height/32,height/6);
		player = GameObject.Find("Player");
	}
	

	void Update ()
	{
		//Open/close the inventory
		if(Input.GetKeyDown(KeyCode.I))
		{
			selected = -1;
			showinventory = !showinventory;
		}
	}
	
	void OnGUI()
	{
		//HUD
		GUI.BeginGroup(hud);
		GUI.DrawTexture(new Rect(0,0,width,32), healthbar_empty);
		GUI.BeginGroup(new Rect(0,0,width/2-height/32,height/6));
		GUI.DrawTexture(new Rect(0,0,width*player.GetComponent<Controller>().health/100,32), healthbar_full);
		GUI.EndGroup();
		GUI.EndGroup();
		//Inventory
		if(showinventory == true)
		{
			GUI.BeginGroup(new Rect(0,0,width,height));
			GUI.Box(new Rect(0,0,width,height),"inventory");
			selected = GUI.SelectionGrid(new Rect(0,0,width,height),selected,itemimages,10);
			GUI.EndGroup();	
		}
	}
	//Update the inventory item image list
	public void UpdateInventory()
	{
		foreach(Texture image in GetComponent<Inventory>().inventory)
		{
			
		}
	}
}
