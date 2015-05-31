using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public GameObject marcador;
	public GameObject ptos;
	int pt;
	void Start ()
	{
//		ptos=GameObject.Find ("PtosText");
//		marcador = GameObject.Find ("Marcador");
//		//ptos=GameObject.Find ("New Text");
//		pt=marcador.GetComponent<ControlMarcador> ().puntos;
//		ptos.GetComponent<TextMesh> ().text = pt.ToString();

		
		
	}
	public void LoadScene (int level)
	{
		Application.LoadLevel (level);
		
	}
}
