using UnityEngine;
using System.Collections;

//Player controller

public class PlayerController : MonoBehaviour
{
	public float health;
	public float healthregen;
	
	public float movementSpeed;
	
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
	
	void FixedUpdate()
	{
		rigidbody.AddForce(new Vector3(1,0,0)*Input.GetAxis("Horizontal")*movementSpeed);	
	}
}
