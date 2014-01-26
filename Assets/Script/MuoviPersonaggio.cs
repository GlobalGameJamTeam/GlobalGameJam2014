using UnityEngine;
using System.Collections;

public class MuoviPersonaggio : MonoBehaviour {

	GestoreEnergia gestoreEnergia;
	Rigidbody c;
	public AudioClip[] movementClips;
	bool playingMusic = false;

	float linearAcceleration = 500;
	float angularAcceleration = 50f;

	// Use this for initialization
	void Start () {
		c = GetComponent<Rigidbody>();
		gestoreEnergia = GetComponent<GestoreEnergia>();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("VITA   --->      " + gestoreEnergia.getEnergia ());
		if (gestoreEnergia == null) {
			return;
		}

		if (gestoreEnergia.getEnergia () >= 0.3f) {

			{
				float rotazioneX = Input.GetAxis ("Mouse X") * angularAcceleration * Time.deltaTime;
				bool retro = false;
				if (rotazioneX < 0) {
					retro = true;
				}
				rotazioneX = Mathf.Min (gestoreEnergia.getEnergia (), Mathf.Abs (rotazioneX));
				rotazioneX = Mathf.Round (rotazioneX * 100f) / 100f;
				gestoreEnergia.subEnergia (rotazioneX / angularAcceleration);
				if (retro) {
					rotazioneX *= -1;
				}
				//transform.Rotate(Vector3.up, rotazione);
				//Debug.Log("rotazione:"+rotazione);
				Quaternion deltaRotation = Quaternion.Euler (Vector3.up * rotazioneX);
				c.MoveRotation (c.rotation * deltaRotation);
				//c.MoveRotation();
			}
			{
				float rotazioneY = Input.GetAxis ("Mouse Y") * angularAcceleration * Time.deltaTime;
				bool retro = false;
				if (rotazioneY < 0) {
					retro = true;
				}
				rotazioneY = Mathf.Min (gestoreEnergia.getEnergia (), Mathf.Abs (rotazioneY));
				rotazioneY = Mathf.Round (rotazioneY * angularAcceleration) / 100f;
				gestoreEnergia.subEnergia (rotazioneY / angularAcceleration);
				if (retro) {
					rotazioneY *= -1;
				}
				Quaternion deltaRotation = Quaternion.Euler (Vector3.up * rotazioneY);
				c.MoveRotation (c.rotation * deltaRotation);
			}

			{
				float velocita = Input.GetAxis("Horizontal") * linearAcceleration * Time.deltaTime;
				bool retro = false;
				if (velocita < 0){
					retro = true;
				}
				velocita = Mathf.Min(gestoreEnergia.getEnergia(), Mathf.Abs(velocita) );
				velocita = Mathf.Round(velocita*linearAcceleration)/100f;
				gestoreEnergia.subEnergia(velocita/linearAcceleration);
				if (retro){
					velocita *= -1;
				}
				if(!playingMusic && velocita != 0){
					int i = Random.Range(0, movementClips.Length);
					AudioSource.PlayClipAtPoint(movementClips[i], this.transform.position);
					playingMusic = !playingMusic;
					Invoke("enableSound", movementClips[i].length);
				}
				c.AddRelativeForce(Vector3.left * velocita);
			}

			{
				float velocita = Input.GetAxis("Vertical") * linearAcceleration * Time.deltaTime;
				bool retro = false;
				if (velocita < 0){
					retro = true;
				}
				velocita = Mathf.Min(gestoreEnergia.getEnergia(), Mathf.Abs(velocita) );
				velocita = Mathf.Round(velocita*linearAcceleration)/100f;
				gestoreEnergia.subEnergia(velocita/linearAcceleration);
				if (retro){
					velocita *= -1;
				}
				if(!playingMusic && velocita != 0){
					int i = Random.Range(0, movementClips.Length);
					AudioSource.PlayClipAtPoint(movementClips[i], this.transform.position);
					playingMusic = !playingMusic;
					Invoke("enableSound", movementClips[i].length);
				}
				c.AddRelativeForce(Vector3.forward * velocita);
			}
			//Debug.Log("velocita:"+velocita);
		}
	}

	void enableSound(){
		playingMusic = false;
	}
}
