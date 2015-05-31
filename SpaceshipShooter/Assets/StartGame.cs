using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public GameObject marcador;

	void Start ()
	{
		marcador = GameObject.Find ("Marcador");

		
		
	}
	public void LoadScene (int level)
	{
		Application.LoadLevel (level);
		
	}
}
