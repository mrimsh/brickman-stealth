using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour
{
	public int maxHP;
	private int currentHP;
	private float fall;
	private float lastY;
	private float distToGround;
	// Use this for initialization
	void Start ()
	{
		
		currentHP = maxHP;
		lastY = transform.position.y;
		distToGround = collider.bounds.extents.y;
	}

	private  bool IsGrounded ()
	{
		return Physics.Raycast (transform.position, -Vector3.up, distToGround + 0.15f);
	}
	// Update is called once per frame
	void Update ()
	{
		if (currentHP < 0) {
			currentHP = 0;
			print ("He died");
		}
			
		if (IsGrounded ()) {
			if (fall > 4.0f) {
				print ("I FELT");
				currentHP -= 10;
			}
			print ("I Prizimlilsa"); 
			fall = 0;	
		} else {
			fall = lastY - transform.position.y; 
		}
		//print("position : " + transform.position.y);
		print ("fall :" + fall);
		print ("HP :" + currentHP);
		
	
	}
}
