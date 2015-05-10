using UnityEngine;
using System.Collections;

public class EndOfLevel1 : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col) 
	{
		Debug.Log ("passe3");
		Application.LoadLevel("Boss1");
	}
}
