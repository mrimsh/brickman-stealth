using UnityEngine;
using System.Collections;

public class motionOfAWDS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.W))
		{
			 transform.Translate(0, 0, 2);
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			transform.Translate(0,0,-2);
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			transform.Translate(-2,0,0);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			transform.Translate(2,0,0);
		}
		
	}
}
