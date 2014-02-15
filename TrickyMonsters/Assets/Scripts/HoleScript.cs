using UnityEngine;
using System.Collections;

public class HoleScript : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		var monster = coll.gameObject;
		if (monster != null)
		{
			monster.SendMessage("HoldIt");
			var position = transform.position;
			transform.Translate(0,0,1); 
			monster.transform.position = position;
		}
	}
}
