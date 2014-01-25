using UnityEngine;
using System.Collections;

public class MuoviPersonaggio : MonoBehaviour {

	GestoreEnergia gestoreEnergia;
	Rigidbody c;

	// Use this for initialization
	void Start () {
		c = GetComponent<Rigidbody>();
		gestoreEnergia = GetComponent<GestoreEnergia>();
	}
	
	// Update is called once per frame
	void Update () {
		if (gestoreEnergia == null) {
			return;
		}

		if (gestoreEnergia.getEnergia() >= 0){
			float speedIncrese = 500;
			float rotateSpeed = 50f;

			float rotazione = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
			bool retro = false;
			if (rotazione < 0){
				retro = true;
			}
			rotazione = Mathf.Min(gestoreEnergia.getEnergia(), Mathf.Abs(rotazione) );
			rotazione = Mathf.Round(rotazione*100f)/100f;
			gestoreEnergia.subEnergia(rotazione/rotateSpeed);
			if (retro){
				rotazione *= -1;
			}
			//transform.Rotate(Vector3.up, rotazione);
			//Debug.Log("rotazione:"+rotazione);
			c.AddRelativeTorque(Vector3.up * rotazione);
		
			float velocita = Input.GetAxis("Vertical") * speedIncrese * Time.deltaTime;
			retro = false;
			if (velocita < 0){
				retro = true;
			}
			velocita = Mathf.Min(gestoreEnergia.getEnergia(), Mathf.Abs(velocita) );
			velocita = Mathf.Round(velocita*100f)/100f;
			gestoreEnergia.subEnergia(velocita/speedIncrese);
			if (retro){
				velocita *= -1;
			}
			//transform.Translate(Vector3.forward * velocita);

			c.AddRelativeForce(Vector3.forward * velocita);
			//Debug.Log("velocita:"+velocita);
		}
	}
}
