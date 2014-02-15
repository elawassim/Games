using UnityEngine;
using System.Collections;

public class BlockingScript : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll) 
	{
		var monster = coll.gameObject;
		if (monster != null)
		{
			monster.SendMessage("Stop");
		}
	}


}
