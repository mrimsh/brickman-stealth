using UnityEngine;
using System.Collections;

public class MovePiston : MonoBehaviour {
	
	public float x=0;
	public float y=0;
	public float z=0;
	public float MoveSpend;
	
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
				while (y==3)
		{
    transform.Translate(x,y,z);
		}
	}
}
