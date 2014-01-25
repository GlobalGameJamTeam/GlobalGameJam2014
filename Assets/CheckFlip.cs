using UnityEngine;
using System.Collections;

public class CheckFlip : MonoBehaviour {

	float energyLostSeconds = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody r = GetComponent<Rigidbody> ();
		float xValue = r.transform.eulerAngles.x;
		float zValue = r.transform.eulerAngles.z;
		//Debug.Log ("yValue "+yValue);
		if (Mathf.Abs(xValue)>10 || Mathf.Abs(zValue)>10) {
			GestoreEnergia g = GetComponent<GestoreEnergia>();
			g.subEnergia(Time.deltaTime * energyLostSeconds);
		}
	}
}
