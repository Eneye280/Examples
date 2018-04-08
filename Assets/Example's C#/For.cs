using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class For : MonoBehaviour 
{
	[SerializeField] GameObject prefab;
	void Start () 
	{
/*Imprimir el abecedario */
		char letra;
		int numero;
		int numeroDos;
		for(letra = 'a'; letra <= 'z'; letra++)
		{
			for(numero = 0; numero <= 10; letra++ )
			{
				for(numeroDos = 0; numeroDos <=10; numero++)
				{
					print(letra);
				}
			}
		}		
		StartCoroutine(ForClass());
	}
	private IEnumerator ForClass()
	{
		for (int i = 0; i <= 10; i++)
		{
/*Intervalo de segundo por cada ciclo de repeticion (no forza tanto al procesador)*/
			Thread.Sleep(1);
			print(i);
			yield return new WaitForSeconds(2);
			var box = Instantiate<GameObject>(prefab);
			if(i == 10)
			{
				break;
			}
		}
	}
}
