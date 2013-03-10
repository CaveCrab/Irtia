using UnityEngine;
using System.Collections;

//Player HUD

public class HUD : MonoBehaviour
{
	public Texture2D healthbar_empty;
	public Texture2D healthbar_full;
	
	Rect hud;
	int height;
	int width;
	
	GameObject player;
	
	void Start ()
	{
		width = Screen.width;
		height = Screen.height;
		hud = new Rect(height/32,height/32,width/2-height/32,height/6);
		player = GameObject.Find("Player");
	}
	

	void Update ()
	{
	
	}
	
	void OnGUI()
	{
		GUI.BeginGroup(hud);
		GUI.DrawTexture(new Rect(0,0,width,32), healthbar_empty);
		GUI.BeginGroup(hud);
		GUI.DrawTexture(new Rect(0,0,width*player.GetComponent<Controller>().health/100,32), healthbar_full);
		GUI.EndGroup();
		GUI.EndGroup();
	}
}
