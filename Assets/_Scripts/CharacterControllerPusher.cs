using UnityEngine;
using System.Collections;

public class CharacterControllerPusher : MonoBehaviour
{
	
	public float pushSpeed = 0.002f;
	GameObject mrBrick;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		//MrBric.transform.position += Vector3.right*10.0f;
	    
	}
	
	void OnCollisionStay (Collision collision)
	{
		
		   
		if (collision.contacts != null) {
			ContactPoint contact = collision.contacts [0];
			
			Vector3 posCol = contact.point;
			mrBrick = contact.otherCollider.gameObject;
			CharacterController controller = mrBrick.GetComponent<CharacterController> ();
			if (controller != null) {
				Vector3 posMr = mrBrick.transform.position;
				Vector3 length = posMr - posCol;
				length.x = - length.x;
				length.z = - length.z;
							
				controller.Move ((mrBrick.transform.rotation * Vector3.right).normalized * pushSpeed * Time.fixedTime);
			
			}
			
		}
		
		
	}
}
