using UnityEngine;
using System.Collections;

public class generardorEnemigos : MonoBehaviour {

	public Rigidbody2D asteroideG1;
	public Rigidbody2D asteroideG2;
	public Rigidbody2D asteroideG3;
	public Rigidbody2D asteroideM;
	public GameObject marcador;
	// Para controlar el tiempo entre cada asteroide generado
	private float intervalo;
	private int ptos;
	//private static int ptos;
	void Start(){
		marcador=GameObject.Find ("Marcador");
		ptos = marcador.GetComponent<ControlMarcador> ().puntos;
	}
	void GenerarAsteroide ()
	{
		// Calculamos una posición inicial para el asteroide de forma aleatoria
		Vector2 posicionInicial = new Vector2 (transform.position.x + ((Random.value * 50f) - 25f), transform.position.y);
		//GameObject marcador=GameObject.Find("Marcador");
		
		
		
		//marcador.GetComponent<script>().
		// Clonamos el objeto de uno de los cuatro tipos
		int tipoAsteroide = Random.Range (0, 4);
		
		Rigidbody2D asteroide = null;
		
		switch (tipoAsteroide) {
		case 0:
			asteroide = (Rigidbody2D)Instantiate (asteroideG1, posicionInicial, transform.rotation);
			break;
		case 1:
			asteroide = (Rigidbody2D)Instantiate (asteroideG2, posicionInicial, transform.rotation);
			break;
		case 2:
			asteroide = (Rigidbody2D)Instantiate (asteroideG3, posicionInicial, transform.rotation);
			break;
		case 3:
			asteroide = (Rigidbody2D)Instantiate (asteroideM, posicionInicial, transform.rotation);
		//	asteroide.GetComponent<ControlAsteroide>().puntos = 500;
			break;
		}
		
		// Le damos rotación y lo escalamos un poco para que parezcan diferentes 
		asteroide.AddTorque (Random.value * 10f);
		float escala = Random.Range (.5f, 0.7f);
		asteroide.transform.localScale = new Vector3 (escala, escala, escala);
		//asteroide.transform.Translate (Vector3.down * 100f * Time.deltaTime);
		//asteroide.WakeUp ();
		//asteroide.mass = -1;

	}
	
	void Update ()
	{	
		if (Time.time > intervalo) {
			GenerarAsteroide ();
			intervalo += Random.Range (.25f, 3f);
			
			
		}
		switch (ptos) {
		case 100:
			if (Time.time > intervalo) {
				GenerarAsteroide ();
				intervalo += Random.Range (.25f, 0.1f);
			}
			break;
			
			
			
			
		}
		
	}
}
