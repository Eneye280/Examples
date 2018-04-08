using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class Calculadora : MonoBehaviour 
{
	[Header("Mouse")]
	[SerializeField] private Texture2D 		textureMouse;
	private Vector2 		vectorMouse = Vector2.zero;
	private CursorMode 	cursorMode = CursorMode.Auto;

	[Header("Funcion Calculadora")]
	[SerializeField] private Font 	fuente;
	private string textoImprimir;
	private string textoResultado;
	private string otroNumero;
	private string valor1;
	private string valor2;
	private string operacionActual;
	private string operacion;

	[Header("Camara")]
	private Camera 	cameraFunction;

	private void Start()
	{
		cameraFunction = GetComponent<Camera>();
		cameraFunction.clearFlags = CameraClearFlags.SolidColor;
		cameraFunction.backgroundColor = Color.black;
		Cursor.SetCursor(textureMouse,vectorMouse,cursorMode);
	}

	private void OnGUI()
	{
		GUI.skin.font = fuente;
		GUI.contentColor = Color.cyan;
/*NUMEROS DE LA CALCULADORA */
		if(GUI.Button(new Rect(220,300,50,50),"0"))
		{
			textoImprimir = "0";
			textoResultado = textoResultado + textoImprimir;
		}	 	
		if(GUI.Button(new Rect(170,250,50,50),"1"))
		{
			textoImprimir = "1";
			textoResultado = textoResultado + textoImprimir;
		}
		if(GUI.Button(new Rect(220,250,50,50),"2"))
		{
			textoImprimir = "2";
			textoResultado = textoResultado + textoImprimir;
		}
		if(GUI.Button(new Rect(270,250,50,50),"3"))
		{
			textoImprimir = "3";
			textoResultado = textoResultado + textoImprimir;

		}
		if(GUI.Button(new Rect(170,200,50,50),"4"))
		{
			textoImprimir = "4";
			textoResultado = textoResultado + textoImprimir;
			
		}
		if(GUI.Button(new Rect(220,200,50,50),"5"))
		{
			textoImprimir = "5";
			textoResultado = textoResultado + textoImprimir;

		}
		if(GUI.Button(new Rect(270,200,50,50),"6"))
		{
			textoImprimir = "6";
			textoResultado = textoResultado + textoImprimir;

		}
		if(GUI.Button(new Rect(170,150,50,50),"7"))
		{
			textoImprimir = "7";
			textoResultado = textoResultado + textoImprimir;

		}
		if(GUI.Button(new Rect(220,150,50,50),"8"))
		{
			textoImprimir = "8";
			textoResultado = textoResultado + textoImprimir;

		}
		if(GUI.Button(new Rect(270,150,50,50),"9"))
		{
			textoImprimir = "9";
			textoResultado = textoResultado + textoImprimir;

		}

/*SIGNOS DE LA CALCULADORA */
		if(GUI.Button(new Rect(320,250,50,50),"+"))
		{
			if(textoResultado != "")
			{
				operacion = "+";
				otroNumero = textoResultado;
				textoImprimir = "";
				textoResultado = textoImprimir;
			}

		}
		if(GUI.Button(new Rect(320,200,50,50),"-"))
		{
			if(textoResultado != "")
			{
				operacion = "-";
				otroNumero = textoResultado;
				textoImprimir = "";
				textoResultado = textoImprimir;
			}
		}	
		if(GUI.Button(new Rect(320,150,50,50),"*"))
		{
			if(textoResultado != "")
			{
				operacion = "*";
				otroNumero = textoResultado;
				textoImprimir = "";
				textoResultado = textoImprimir;
			}
		}
		if(GUI.Button(new Rect(320,100,50,50),"÷"))
		{
			if(textoResultado != "")
			{
				operacion = "÷";
				otroNumero = textoResultado;
				textoImprimir = "";
				textoResultado = textoImprimir;
			}
		}
		if(GUI.Button(new Rect(270,100,50,50), "<"))
		{
			if(textoResultado != "")
			{
				operacion = "";
				otroNumero = textoResultado;
				textoImprimir = "";
				textoResultado = textoImprimir;
			}
		}

		if(GUI.Button(new Rect(270,300,50,50),","))
		{
			textoImprimir = ",";
			textoResultado = textoResultado + textoImprimir;
		}
		if(GUI.Button(new Rect(170,50,50,50),"CE"))
		{
			textoImprimir = "";
			textoResultado = "";
			otroNumero = "";
		}

/*PANEL DE RESULTADOS*/	
		GUI.TextArea(new Rect(222,50,150,50),""+ textoResultado);

		if(GUI.Button(new Rect(320,300,50,50),"="))
		{

			if(textoResultado != "" && operacion == "+")
			{
				valor2 = textoResultado;
				valor1 = otroNumero;
				operacionActual = operacion;
				textoResultado = (double.Parse(valor1) + double.Parse(valor2)).ToString();
			}
			if(textoResultado != "" && operacion == "-")
			{
				valor2 = textoResultado;
				valor1 = otroNumero;
				operacionActual = operacion;
				textoResultado = (double.Parse(valor1) - double.Parse(valor2)).ToString();
			}
			if(textoResultado != "" && operacion == "*")
			{
				valor2 = textoResultado;
				valor1 = otroNumero;
				operacionActual = operacion;
				textoResultado = (double.Parse(valor1) * double.Parse(valor2)).ToString();
			}
			if(textoResultado != "" && operacion == "÷")
			{
				valor2 = textoResultado;
				valor1 = otroNumero;
				operacionActual = operacion;
				textoResultado = (double.Parse(valor1) / double.Parse(valor2)).ToString();
			}
			if(textoResultado != "" && operacion == "<")
			{
				operacion = "";
				textoImprimir = "";
				textoResultado = textoImprimir + textoResultado;
			}

		}
	}
}
