using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
	/*retorna el valor de un producto */
	public int experiencia;

	public int Experiencia
	{
		get
		{
			return experiencia;
		}
		set
		{
			experiencia = value; 
		}
	}

	public int valor
	{
		get 
		{
			return experiencia / 100;
		}
		set
		{
			experiencia = value * 100;
		}
	}

void Start()
{
	print(experiencia);
}

}
