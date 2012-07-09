using UnityEngine;
using System.Collections;

public class ObjectPusher : MonoBehaviour
{
	public float pushPower = 2.0F;
	public ControllerColliderHit hit;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}
	
	void OnControllerColliderHit (ControllerColliderHit hit)
	{
		Rigidbody body = hit.collider.attachedRigidbody;
		if (body == null || body.isKinematic)
			return;
        
		if (hit.moveDirection.y < -0.3F)
			return;
        
		Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
		body.velocity = pushDir * pushPower;
	}
}
