using UnityEngine;
using System.Collections;

public class Spawnaluce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			object NewLight;
			NewLight = Instantiate(Resources.Load("Light"),this.transform.position, this.transform.rotation);


		}
	
	}
}
