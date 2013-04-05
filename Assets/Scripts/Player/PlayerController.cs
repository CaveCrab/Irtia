using UnityEngine;
using System.Collections;

//Player controller

public class PlayerController : MonoBehaviour
{
	public float health;
	public float healthregen;
	
	void Start ()
	{
		
	}
	
	void Update ()
	{
		if(health < 100)
		{
			health += healthregen*Time.fixedDeltaTime;
		}
	}
}
