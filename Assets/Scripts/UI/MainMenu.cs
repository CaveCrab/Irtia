using UnityEngine;
using System.Collections;

//Main menu: rendering and shifting between scenes (levels)

public class MainMenu : MonoBehaviour
{
	int width, height;
	
	void Start ()
	{
		width = Screen.width;
		height = Screen.height;
	}
	

	void Update ()
	{
	
	}
	
	void OnGUI()
	{
		GUI.BeginGroup(new Rect(width/4,0,width/2,height));
		if(GUI.Button(new Rect(0,0,width/2,height/5),"New Game"))
		{
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(0,height/5,width/2,height/5),"Continue"))
		{
			Application.LoadLevel(2);
		}
		if(GUI.Button(new Rect(0,height/5*2,width/2,height/5),"Settings"))
		{
			Application.LoadLevel(3);
		}
		if(GUI.Button(new Rect(0,height/5*3,width/2,height/5),"Credits"))
		{
			Application.LoadLevel(4);
		}
		if(GUI.Button(new Rect(0,height/5*4,width/2,height/5),"Quit"))
		{
			Application.Quit();
		}
		GUI.EndGroup();
	}
}
