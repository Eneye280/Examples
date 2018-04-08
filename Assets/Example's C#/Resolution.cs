using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Resolution : MonoBehaviour 
{
	private void Start()
	{
		Screen.SetResolution(16,9,true);
		Screen.fullScreen = true;

/*Configurar los ajustes dependiendo de la plataforma */
#if UNITY_ANDROID
		print("Esta pa android");
#elif UNITY_EDITOR_WIN
		print("Esta para editor windows");
#endif

		if(Screen.fullScreen)
		{
			Debug.Log("Pantalla Completa," + Screen.fullScreen);
		}

/*Saber si existe otra pantalla a la cual conectarse */
		if(Display.displays.Length > 1)
		{
			Display.displays[1].Activate();
		}
		else
		{
			print("No existe otro monitor");
		}
/*TRUCO PARA REBAJAR LOS FPS DE DISPOSITIVOS MOVILES */
		float factor = 0.5f;
		Screen.SetResolution(
			Mathf.CeilToInt(Screen.currentResolution.width * factor),
			Mathf.CeilToInt(Screen.currentResolution.height * factor),
			true);
	}
}
