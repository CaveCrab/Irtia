using UnityEngine;
using System.Collections;

//Player HUD

public class HUD : MonoBehaviour
{	
	//inventory item category selection and
	public Texture[] categories;
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
		player = gameObject;
		categories = new Texture[12];
		showinventory = false;
		width = Screen.width;
		height = Screen.height;
		hud = new Rect(height/32,height/32,width/2-height/32,height/6);
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
		GUI.DrawTexture(new Rect(0,0,width*player.GetComponent<PlayerController>().health/100,32), healthbar_full);
		GUI.EndGroup();
		GUI.EndGroup();
		//Inventory
		if(showinventory == true)
		{
			GUI.BeginGroup(new Rect(0,0,width,height));
			GUI.Box(new Rect(0,0,width,height),"inventory");
			selected = GUI.SelectionGrid(new Rect(0,0,width,height),selected,categories,3);
			GUI.EndGroup();	
		}
		if(selected != -1)
		{
			switch (selected)
			{
			case 2:
				break;
			case 4:
				break;
			case 5:
				break;
			case 6:
				break;
			case 7:
				break;
			case 8:
				break;
			case 9:
				break;
			case 11:
				break;	

			}
		}
	}
}
