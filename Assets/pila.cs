using UnityEngine;
using System.Collections;

public class pila : MonoBehaviour {

	private GestoreEnergia manager;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find("Player").GetComponent<GestoreEnergia>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision){
		Debug.Log ("muori");
		float energia = manager.getEnergia();
		manager.setEnergia(energia + 60);
		Destroy(this.gameObject);
	}
}
