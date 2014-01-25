﻿using UnityEngine;
using System.Collections;

public class FlashlightComponent : MonoBehaviour {

	public bool on;
	GameObject flashlight;
	GestoreEnergia gestoreEnergia;
	
	// Use this for initialization
	void Start () {
		flashlight = Instantiate (Resources.Load ("Light"), Camera.main.transform.position, Camera.main.transform.rotation) as GameObject;
		flashlight.transform.parent = gameObject.transform;
		gestoreEnergia = GetComponent<GestoreEnergia>();
		on= false;
	}
	
	// Update is called once per frame
	void Update () {
		float currentEnergy = gestoreEnergia.getEnergia();
		if (on){
			flashlight.light.enabled = true;
			gestoreEnergia.subEnergia (4*Time.deltaTime);
		}
		else if(!on)
			flashlight.light.enabled = false;
		if(Input.GetButtonDown ("Fire2"))
			on = !on;
		if (currentEnergy < 1f)
			on = false;
	}
}