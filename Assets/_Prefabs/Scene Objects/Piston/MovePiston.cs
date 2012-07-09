using UnityEngine;
using System.Collections;

public class MovePiston : MonoBehaviour
{
	public float rate;
	public float Maxlength;
	public float Minlength;
	private bool isMovingUp = true;
	Transform pisty;
	
	// Use this for initialization
	void Start ()
	{
		pisty = transform.Find ("Pisty");
		CharacterControllerPusher ccp = pisty.GetComponent<CharacterControllerPusher> ();
		if (ccp!= null)
		{
			ccp.pushSpeed = rate * 0.002f;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (isMovingUp) {
			if (pisty.localPosition.y >= Maxlength) {
				isMovingUp = false;
			} else {
				Vector3 movement = Vector3.up * rate * Time.deltaTime;
				movement = transform.localRotation * movement;
				pisty.rigidbody.MovePosition (pisty.rigidbody.position + movement);
			}
		} else {
			if (pisty.localPosition.y <= Minlength) {
				isMovingUp = true;
			} else {
				Vector3 movement = Vector3.down * rate * Time.deltaTime;
				movement = transform.localRotation * movement;
				pisty.rigidbody.MovePosition (pisty.rigidbody.position + movement);
			}
		}
	}
}
