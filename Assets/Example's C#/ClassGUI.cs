using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassGUI : MonoBehaviour 
{
	public Font fuenteLetra;
	private Camera cameraMain;
	public int x;
	public int y;
	public int largo;
	public int ancho;
	private string nombre = "";
	private char cubrirContraseña;
	//public Texture textura;
	
	private void Start()
	{
		cubrirContraseña = '*';
/*Acceder a las funciones de la camara */
		cameraMain = GetComponent<Camera>();
		cameraMain.clearFlags = CameraClearFlags.SolidColor;
		cameraMain.backgroundColor = Color.black;
	}
	private void OnGUI()
	{
/*La fuente que tendra la letra */
		GUI.skin.font = fuenteLetra;

/*Color de la letra */
		GUI.contentColor = Color.green;

/*Se usa para no dejar que el usuario cliquee sobre el texto*/
		//GUI.FocusControl(nombre);

/*Mostrar simplemente un texto, va ligado con la de arriba*/
		//GUI.TextArea(new Rect(215,35,200,70),"    Welcome");

/*Escribir un texto*/
		//nombre = GUI.TextField(new Rect(215,150,200,70),nombre);

/*Agregar una imagen al boton */
		//GUI.DrawTexture(new Rect(215,150,70,70),textura);

/*Ingresar una contraseña */
		nombre = GUI.PasswordField(new Rect(215,35,200,70), nombre, cubrirContraseña);

/*Presionar El boton */
		if(GUI.Button(new Rect(x,y,largo,ancho),"Iniciar Game"))
		{
			print(1);
		}
	}
}
