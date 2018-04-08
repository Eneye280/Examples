using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SistemaDeGuardado : MonoBehaviour 
{
	public int numeroEntero = 0;
	public float numeroDecimal = 0f;
	public string texto = "";
	public bool verificarCargaJuego;
	public bool GuardadoAutomatico;
	public int TiempoGuardar;
	void Start () 
	{
		if(verificarCargaJuego)
			Cargar();
		if(GuardadoAutomatico)
			InvokeRepeating("Guardar",0,TiempoGuardar);
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.G))
		{
			Guardar();
		}
		if(Input.GetKeyDown(KeyCode.C))
		{
			Cargar();
		}
		if(Input.GetKeyDown(KeyCode.B))
		{
			Borrar();
		}
	}
	public void Cargar()
	{
		if(File.Exists(Application.persistentDataPath + "/Datos.d"))
		{
			BinaryFormatter fb = new BinaryFormatter();
			FileStream Expediente = File.OpenRead(Application.persistentDataPath + "/Datos.d");
			DatosDeJuego Datos = new DatosDeJuego();

			Datos = fb.Deserialize(Expediente) as DatosDeJuego;

			numeroEntero = Datos.numeroEntero;
			numeroDecimal = Datos.numeroDecimal;
			texto = Datos.texto;

			print("Cargo");
		}
		else
		{
			print("No existe archivo");
		}
	}
	public void Guardar()
	{
		BinaryFormatter fb = new BinaryFormatter();
		FileStream Expediente = File.Create(Application.persistentDataPath + "/Datos.d");
		DatosDeJuego Datos = new DatosDeJuego();

		Datos.numeroEntero = numeroEntero;
		Datos.numeroDecimal = numeroDecimal;
		Datos.texto = texto;

		fb.Serialize(Expediente, Datos);
		Expediente.Close();

		print("Guarde");
	}
	public void Borrar()
	{
		if(File.Exists(Application.persistentDataPath + "/Datos.d"))
		{
			File.Delete(Application.persistentDataPath + "/Datos.d");

			numeroEntero = new int();
			numeroDecimal = new float();
			texto = "";

			print("Borro");
		}
		else
		{
			print("No existe archivo");
		}
	}
}
[Serializable()]
class DatosDeJuego : System.Object
{
	public int numeroEntero;
	public float numeroDecimal;
	public string texto;
}
