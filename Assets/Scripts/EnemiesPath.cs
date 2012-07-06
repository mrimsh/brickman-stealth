using UnityEngine;
using System.Collections;

public class EnemiesPath : MonoBehaviour
{
	[HideInInspector]
	public static bool PlayerIsAttackable = false;
	[HideInInspector]
	public static bool PlayerIsVisible = false;
	public int currentTarget=0;
	private GameObject lasttarget;
	public GameObject[] targets;
	// Use this for initialization
	void Start ()
	{
			currentTarget=GetNearlyPoint();
		lasttarget=targets[currentTarget];
	}
	// Update is called once per frame
	void Update ()
	{
		if (PlayerIsAttackable || PlayerIsVisible) {
			GameObject player = GameObject.FindGameObjectWithTag ("Player");
			lasttarget = player;
			Vector3 pointcoor = player.transform.position;
			Vector3 thiscoor = this.transform.position;
		
			Vector3 nextStep = new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).normalized * 5;
			if (nextStep.magnitude < new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).magnitude) {
				transform.position += nextStep * Time.deltaTime;
			} else {
				
			}
			
		} else {
			
			if (lasttarget.tag == "Player") {
				currentTarget = GetNearlyPoint ();
			}
			Vector3 pointcoor = targets [currentTarget].transform.position;
			lasttarget = targets [currentTarget];
			
			//this.transform.LookAt (targets [currentTarget].transform);
			Vector3 thiscoor = this.transform.position;
			Vector3 nextStep = new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).normalized * 5;
			if (nextStep.magnitude > new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).magnitude) {
				currentTarget++;
				if (currentTarget > targets.Length - 1) {
					currentTarget = 0;
				}
			}
			Debug.Log("I'm going");
			transform.position += nextStep * Time.deltaTime;
		}		
	}
	
	private int GetNearlyPoint ()
	{
		int result = 0;
		for (int i=1; i<targets.Length-1; i++) {
			if (new Vector3 (targets [i].transform.position.x - transform.position.x,
			targets [i].transform.position.y - transform.position.y,
			targets [i].transform.position.z - transform.position.z).magnitude < 
				new Vector3 (targets [result].transform.position.x - transform.position.x,
			targets [result].transform.position.y - transform.position.y,
			targets [result].transform.position.z - transform.position.z).magnitude) {
				result = i;
			}
		}
		return result;
	}
}