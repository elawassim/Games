using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour {

	public bool isStopped = true;
	public bool isInHole = false;
	private Vector2 movement = new Vector2(0,0);
	public Vector2 speed = new Vector2(5,5);
	
	void readMovement()
	{
		var input = new Vector2();
		input.x =  Input.GetAxis("Horizontal") ;
		input.y =  Input.GetAxis ("Vertical");
		movement.x = speed.x * input.x;
		movement.y = speed.y * input.y;
		if(movement.x != 0 || movement.y != 0) isStopped = false;
	}

	public void HoldIt(){
		Stop();
		isInHole= true;
	}
	public void Stop(){
		movement = new Vector2 (0, 0);
		isStopped = true;
	}

	void Update () {
		if (isStopped && !(isInHole))  readMovement ();
		movement *= Time.deltaTime;
		transform.Translate (movement);
	}

	/*void FixedUpdate(){
		rigidbody2D.velocity = movement;
	}*/
}
