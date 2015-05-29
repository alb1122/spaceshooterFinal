using UnityEngine;
using System.Collections;

public class controlEnemy : MonoBehaviour {

	public GameObject marcador;
	public GameObject nave;
	// Por defecto, 100 puntos
	public int puntos = 1500;
	public int ndisp=3;
	public GameObject exp;
	public GameObject navExp;
	public GameObject expBomba;
	
	// Localizar y conectar el marcador para poder actualizarlo
	void Start ()
	{
		marcador = GameObject.Find ("Marcador");
		nave = GameObject.Find ("nave");
		
		
	}
	
	// Detectar la colisión entre el asteroide y el disparo
	void OnCollisionEnter2D (Collision2D coll)
	{

		
		if (coll.gameObject.tag == "disparo") {
			// Sumar la puntuación de este asteroide
			GetComponent<AudioSource> ().Play ();
			ndisp = ndisp - 1;
			coll.gameObject.GetComponent<Renderer> ().enabled = false;
			coll.gameObject.GetComponent<Collider2D> ().enabled = false;
			Instantiate (exp, transform.position, transform.rotation);
			if (ndisp == 0) {
				marcador.GetComponent<ControlMarcador> ().puntos += puntos;
				Instantiate (exp, transform.position, transform.rotation);
				GetComponent<Renderer> ().enabled = false;
				GetComponent<Collider2D> ().enabled = false;
			}
			
			
			
			// El disparo desaparece
			//coll.gameObject.GetComponent<ParticleAnimator>()
			
			
		} else if (coll.gameObject.tag == "asteroide") {
			coll.gameObject.GetComponent<Renderer>().enabled = true;
			coll.gameObject.GetComponent<Collider2D>().enabled = true;
			Instantiate (exp, transform.position, transform.rotation);
			GetComponent<Renderer>().enabled = true;
			GetComponent<Collider2D>().enabled = true;
	
			}


		else if (coll.gameObject.tag == "bomba"){
			GetComponent<AudioSource> ().Play ();
			marcador.GetComponent<ControlMarcador> ().puntos += puntos;
			Instantiate(expBomba,transform.position,transform.rotation);
			coll.gameObject.GetComponent<Renderer>().enabled = false;
			coll.gameObject.GetComponent<Collider2D>().enabled = false;
			Instantiate (exp, transform.position, transform.rotation);
			GetComponent<Renderer>().enabled = false;
			GetComponent<Collider2D>().enabled = false;
		}
		else {
			if (coll.gameObject.tag == "nave") {
				GetComponent<AudioSource> ().Play ();
				// Hemos chocado con la nave, restamos una vida
				Instantiate (exp, transform.position, transform.rotation);
				Destroy(nave);
				GetComponent<Renderer>().enabled = false;
				GetComponent<Collider2D>().enabled = false;
				if (marcador.GetComponent<ControlMarcador> ().vidas > 0) {
					marcador.GetComponent<ControlMarcador> ().vidas -= 1;
				}
			}
		}
		
		// El asteroide se destruye

	}

}
