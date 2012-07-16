using UnityEngine;
using System.Collections;

public class BrickCreation : MonoBehaviour
{
	public float cooldown = 1f;
	private float lastBrickCreationTime = 0f;
	public bool thirdperson = true;
	public int clayAmount = 0;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{		
		if(thirdperson){
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Space) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject downBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				downBrick.transform.position = new Vector3 (brickx, bricky - 1, brickz);
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(downBrick,60);
			}
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.W) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject forwardBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				forwardBrick.transform.position = new Vector3 (brickx, bricky, brickz) + RotationVector3 ();
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(forwardBrick,60);
			}
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.S) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject backwardBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				backwardBrick.transform.position = new Vector3 (brickx, bricky, brickz) + RotationVector3 ();
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy (backwardBrick,60);
			}
		
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.D) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject rightBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				rightBrick.transform.position = new Vector3 (brickx, bricky, brickz) + RotationVector3 ();
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(rightBrick,60);
			}
		
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.A) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				Vector3 position = this.transform.position;
				GameObject leftBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				leftBrick.transform.position = new Vector3 (brickx, bricky, brickz) + RotationVector3 ();
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(leftBrick,60);
			}
		}else{
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Space) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject downBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				downBrick.transform.position = new Vector3 (brickx, bricky - 1, brickz);
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(downBrick,60);
			}
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.W) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject forwardBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				forwardBrick.transform.position = new Vector3 (brickx, bricky, brickz) + new Vector3(0,0,1);
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(forwardBrick,60);
			}
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.S) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject backwardBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				backwardBrick.transform.position = new Vector3 (brickx, bricky, brickz) + new Vector3(0,0,-1);
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(backwardBrick,60);
			}
		
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.D) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				GameObject rightBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				rightBrick.transform.position = new Vector3 (brickx, bricky, brickz) + new Vector3(1,0,0);
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(rightBrick,60);
			}
		
			if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.A) && Time.time - lastBrickCreationTime > cooldown) {
				Debug.Log ("key down");
				Vector3 position = this.transform.position;
				GameObject leftBrick = GameObject.CreatePrimitive (PrimitiveType.Cube);
				int brickx = Round (transform.position.x);
				int bricky = Round (transform.position.y);
				int brickz = Round (transform.position.z);
				leftBrick.transform.position = new Vector3 (brickx, bricky, brickz) + new Vector3(-1,0,0);
				Debug.Log ("Brick created");
				lastBrickCreationTime = Time.time;
				Destroy(leftBrick,60);
			}
		}
	}
	
	private int Round (float coor)
	{
		int result;
		result = Mathf.RoundToInt (coor);
		return result;
	}

	private Vector3 RotationVector3 ()
	{
		Vector3 result = new Vector3 (0, 0, 0);
		float rotation = transform.rotation.y;
		
		if (rotation > 315 || rotation < 45)
			result = new Vector3 (0, 0, 1);
		if (rotation > 45 & rotation < 135)
			result = new Vector3 (-1, 0, 0);

		if (rotation > 135 & rotation < 225)
			result = new Vector3 (0, 0, -1);

		if (rotation > 225 & rotation < 315)
			result = new Vector3 (1, 0, 0);
		
		return result;
	}
	
	private void AddClayAmount(int amount){
		this.clayAmount+=amount;
	}
	
}
