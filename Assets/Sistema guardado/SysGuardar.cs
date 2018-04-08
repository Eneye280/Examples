using UnityEngine;
using System.Collections;

public class SysGuardar : MonoBehaviour 
{
	public static void Guardar_Posicion(Vector3 Posicion)
	{
		PlayerPrefs.SetFloat("x",Posicion.x);
		PlayerPrefs.SetFloat("y",Posicion.y);
		PlayerPrefs.SetFloat("z",Posicion.z);
	}

	public static Vector3 Cargar_Posicion()
	{
		Vector3 Posicion;
		Posicion.x = PlayerPrefs.GetFloat("x");
		Posicion.y = PlayerPrefs.GetFloat("y");
		Posicion.z = PlayerPrefs.GetFloat("z");
		return Posicion;
	}
}
