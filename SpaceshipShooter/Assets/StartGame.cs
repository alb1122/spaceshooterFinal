using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	
	public void LoadScene (int level)
	{
		Application.LoadLevel (level);
		
	}
}
