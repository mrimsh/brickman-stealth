using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		EnemiesPath.PlayerIsAttackable=true;
		
	}
	void OnTriggerExit(){
		EnemiesPath.PlayerIsAttackable=false;
	}
	
}
