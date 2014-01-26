using UnityEngine;
using System.Collections;

public class Calore : MonoBehaviour
{
		bool on;
		PossibileBomba[] poBombe;
		Material calore;
		Material originale;
		GestoreEnergia gestoreEnergia;

		// Use this for initialization
		void Start ()
		{
				on = false;
				gestoreEnergia = (GameObject.Find("Player")).GetComponent<GestoreEnergia> ();
				calore = Resources.Load<Material> ("Calore");
				poBombe = GetComponentsInChildren<PossibileBomba> (); 
				foreach (PossibileBomba poBomba in poBombe) {
						if (poBomba.bomba) {
								originale = poBomba.renderer.material;
						}
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (gestoreEnergia.getEnergia () > 0) {
						if (Input.GetKeyUp (KeyCode.H)) {
								on = !on;
								if (on) {
										foreach (Component poBomba in poBombe) {
												if (poBomba.GetComponent<PossibileBomba> ().bomba) {
														poBomba.renderer.material = calore;
												}
										}
								} else {
										foreach (Component poBomba in poBombe) {
												if (poBomba.GetComponent<PossibileBomba> ().bomba) {
														poBomba.renderer.material = originale;
												}
										}
								}
						}
						if (on) {
								if (!gestoreEnergia.subEnergia (16 * Time.deltaTime)) {
										on = false;
								}
						}
				} else {
						foreach (Component poBomba in poBombe) {
								if (poBomba.GetComponent<PossibileBomba> ().bomba) {
										poBomba.renderer.material = originale;
								}
						}
				}
		}

}
