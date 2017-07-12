using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
	
	public void ChangeToScene (int sceneIndex) 
	{
		Application.LoadLevel (sceneIndex);
	}

	public void ExitApplication ()
	{
		Application.Quit ();
	}
}
