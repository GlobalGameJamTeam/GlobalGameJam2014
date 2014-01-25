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

			float rotazioneX = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
			bool retro = false;
			if (rotazioneX < 0){
				retro = true;
			}
			rotazioneX = Mathf.Min(gestoreEnergia.getEnergia(), Mathf.Abs(rotazioneX) );
			rotazioneX = Mathf.Round(rotazioneX*100f)/100f;
			gestoreEnergia.subEnergia(rotazioneX/rotateSpeed);
			if (retro){
				rotazioneX *= -1;
			}
			//transform.Rotate(Vector3.up, rotazione);
			//Debug.Log("rotazione:"+rotazione);
			Quaternion deltaRotation = Quaternion.Euler(Vector3.up * rotazioneX);
			c.MoveRotation(c.rotation * deltaRotation);
			//c.MoveRotation();
			
			float rotazioneY = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
			retro = false;
			if (rotazioneY < 0){
				retro = true;
			}
			rotazioneY = Mathf.Min(gestoreEnergia.getEnergia(), Mathf.Abs(rotazioneY) );
			rotazioneY = Mathf.Round(rotazioneY*100f)/100f;
			gestoreEnergia.subEnergia(rotazioneY/rotateSpeed);
			if (retro){
				rotazioneY *= -1;
			}
			//transform.Rotate(Vector3.up, rotazione);
			//Debug.Log("rotazione:"+rotazione);
			deltaRotation = Quaternion.Euler(Vector3.up * rotazioneY);
			c.MoveRotation(c.rotation * deltaRotation);
			//c.MoveRotation();

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
