using UnityEngine;
using System.Collections;

public class onclickToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//onclick
		string scene = Application.loadedLevelName;
		Application.LoadLevel(scene);
	}
}
