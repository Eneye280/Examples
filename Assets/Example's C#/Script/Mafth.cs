using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mafth : MonoBehaviour 
{
/*FUNCIONES DE LA CLASE MAFHT */
	void Start()
	{
		//Pow();
		//sqrt();

	}
/*Potencia de un numero*/
	public void Pow()
	{
		float valor01 = 2;
		float valor02 = 4;
		print(Mathf.Pow(valor01,valor02));
	}
/*Raiz cuadrada */
	public void sqrt()
	{
		float valor1 = 2;
		float valor2 = 4;
		print(Mathf.Sqrt(valor1 * valor1 + valor2 * valor2));
	}

	
}
