using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overloading
{
	public int Agregar(int num1, int num2)
	{
		return  num1 + num2;
	}

	public string Agregar(string str1, string str2)
	{
		return str1 + str2;
	}
}

/*Llamar este desde un script aparte */
public class SobreCarg : MonoBehaviour
{
	void Start()
	{
		Overloading sobre = new Overloading();

		sobre.Agregar(1,2);
		sobre.Agregar("Hola","Que mas");
	}
}
