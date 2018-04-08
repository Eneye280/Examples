using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGames : MonoBehaviour 
{
	private void OnGUI()
	{
		if(GUI.Button(new Rect(525,330,137,38), "Volver"))
		{
			SceneManager.LoadScene("SceneLogin");
		}	

		if(GUI.Button(new Rect(178,100,150,38), "Calculadora"))
		{
			SceneManager.LoadScene("SceneCalculation");
		}
	}
	private void Start()
	{
		Camera camera = GetComponent<Camera>();
		camera.clearFlags = CameraClearFlags.SolidColor;
		camera.backgroundColor = Color.black;
	}
}
