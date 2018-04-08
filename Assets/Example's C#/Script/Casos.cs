using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Casos : MonoBehaviour 
{
	[SerializeField] int id = 1;
	[SerializeField] char idf = 'a';
	[SerializeField] string idx = "Hola";
	[SerializeField] GameObject prefabs;
	GameObject box;
	public void Start () 
	{
		switch (id)
		{
			case 0:
				print("The " + id + "Know one");
				break;
			case 1:
				print("The number is " + id);
				box = Instantiate<GameObject>(prefabs);
				box.transform.Translate(5,5,5);
				break;
			default:
				print("Not number");
				break;
		}
		switch(idf)
		{
			case 'a':
				print("es la letra " + idf);
				break;
			case 'b':
				print("No es la letra " + idf);
				break;
		}
		switch (idx)
		{
			case "Hola":
				print("Hola como estas");
				break;
			case "Chao":
				print("Me voy");
				break;
			default:
				break;
		}
		StartCoroutine(corrutina());
		
	}
	IEnumerator corrutina()
	{
		Thread.Sleep(1);
		for (id = 0; id <= 5; id++)
		{
			print(id);
			yield return new WaitForSeconds(1);
			if(id == 5)
			{
				print("Ciclo de numeros terminado");
			}
		}
		yield return new WaitForSeconds(5);
		for(idf = 'a'; idf <= 'z'; idf++)
		{
			print(idf);
			yield return new WaitForSeconds(1);
			if(idf == 'z')
			{
				print("Ciclo de letras terminado");
				print("se creo el " + box);
			}
		}
	}
}
