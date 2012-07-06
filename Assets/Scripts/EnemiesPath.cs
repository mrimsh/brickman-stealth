using UnityEngine;
using System.Collections;

public class EnemiesPath : MonoBehaviour
{
	[HideInInspector]
	public static bool PlayerIsAttackable = false;
	[HideInInspector]
	public static bool PlayerIsVisible = false;
	int currentTarget = 0;
	public GameObject[] targets;
	// Use this for initialization
	void Start ()
	{
			
	}
		// Update is called once per frame
	void Update ()
	{
		if (PlayerIsAttackable||PlayerIsVisible) {
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			this.transform.LookAt(player.transform);
			Vector3 pointcoor = player.transform.position;
			Vector3 thiscoor = this.transform.position;
		
			Vector3 nextStep = new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).normalized * 5;
			if (nextStep.magnitude < new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).magnitude) {
				transform.position+= nextStep * Time.deltaTime;
			} else {
				
			}
			
		} else {
			Vector3 pointcoor = targets [currentTarget].transform.position;
			this.transform.LookAt(targets[currentTarget].transform);
			Vector3 thiscoor = this.transform.position;
			
			Vector3 nextStep = new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).normalized * 5;
			if (nextStep.magnitude > new Vector3 (pointcoor.x - thiscoor.x, 0, pointcoor.z - thiscoor.z).magnitude) {
				currentTarget++;
				if (currentTarget > targets.Length - 1) {
					currentTarget = 0;
				}
			}
			transform.position += nextStep * Time.deltaTime;
		}
	
	}
}