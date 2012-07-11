using UnityEngine;
using System.Collections;

public class BrickCreation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift)&Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("key down");
			GameObject downBrick = GameObject.CreatePrimitive(PrimitiveType.Cube);
			int brickx = Round(transform.position.x);
			int bricky = Round(transform.position.y);
			int brickz = Round(transform.position.z);
			downBrick.transform.position= new Vector3 (brickx,bricky-2,brickz);
			Debug.Log("Brick created");
			//Destroy(downBrick,60);
		}
		if (Input.GetKeyDown(KeyCode.LeftShift)&Input.GetKeyDown(KeyCode.W)){
			Debug.Log("key down");
			GameObject forwardBrick = GameObject.CreatePrimitive(PrimitiveType.Cube);
			int brickx = Round(transform.position.x);
			int bricky = Round(transform.position.y);
			int brickz = Round(transform.position.z);
			forwardBrick.transform.position= new Vector3 (brickx,bricky,brickz)+RotationVector3();
			Debug.Log("Brick created");
			//Destroy(downBrick,60);
		}
		if (Input.GetKeyDown(KeyCode.LeftShift)&Input.GetKeyDown(KeyCode.S)){
			Debug.Log("key down");
			GameObject backwardBrick = GameObject.CreatePrimitive(PrimitiveType.Cube);
			int brickx = Round(transform.position.x);
			int bricky = Round(transform.position.y);
			int brickz = Round(transform.position.z);
			backwardBrick.transform.position= new Vector3 (brickx,bricky,brickz)+RotationVector3();
			Debug.Log("Brick created");
			//Destroy(downBrick,60);
		}
		
		if (Input.GetKeyDown(KeyCode.LeftShift)&Input.GetKeyDown(KeyCode.D)){
			Debug.Log("key down");
			GameObject rightBrick = GameObject.CreatePrimitive(PrimitiveType.Cube);
			int brickx = Round(transform.position.x);
			int bricky = Round(transform.position.y);
			int brickz = Round(transform.position.z);
			rightBrick.transform.position= new Vector3 (brickx,bricky,brickz)+RotationVector3();
			Debug.Log("Brick created");
			//Destroy(downBrick,60);
		}
		
		if (Input.GetKeyDown(KeyCode.LeftShift)&Input.GetKeyDown(KeyCode.A)){
			Debug.Log("key down");
			Vector3 position = this.transform.position;
			GameObject leftBrick = GameObject.CreatePrimitive(PrimitiveType.Cube);
			int brickx = Round(transform.position.x);
			int bricky = Round(transform.position.y);
			int brickz = Round(transform.position.z);
			leftBrick.transform.position= new Vector3 (brickx,bricky,brickz)+RotationVector3();
			Debug.Log("Brick created");
			//Destroy(downBrick,60);
		}
	}
	
	private int Round(float coor){
		int result;
		result=Mathf.RoundToInt(coor);
		if (result%2!=0){
			result--;
		}
		return result;
	}
	private Vector3 RotationVector3(){
		Vector3 result = new Vector3(0,0,0);
		float rotation = transform.rotation.y;
		if (rotation>315||rotation<45)
			result=  new Vector3(0,0,2);
		if (rotation>45&rotation<135)
			result = new Vector3(-2,0,0);

		if (rotation>135&rotation<225)
			result = new Vector3(0,0,-2);

		if (rotation>225&rotation<315)
			result = new Vector3(2,0,0);
		
		return result;
	}
	
}
