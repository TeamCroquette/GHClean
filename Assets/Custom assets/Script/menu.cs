using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI () {


		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(Screen.width/2,Screen.height/2,Screen.width/8,Screen.height/8), "Start")) {
			Application.LoadLevel(1);
		}
		
//		// Make the second button.
//		if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
//			Application.LoadLevel(2);
//		}
	}







}
