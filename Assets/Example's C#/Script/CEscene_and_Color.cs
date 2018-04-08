using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CEscene_and_Color : MonoBehaviour 
{
	/*Cambiar escena sin destruir objetos que se necesitan (Player,Aliados,etc) */
	/*Este script se le agrega al personaje, en caso de ser un juego */
	public GameObject caja;
	int numCajas = 5;
	public Color[] colorCaja;
	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("Player"))
		{
			Object.DontDestroyOnLoad(caja);
			SceneManager.LoadScene("PruebaDos");
			
		}
	}
	void Start()
	{
		//Aplicar Un color random a una lista de objetos
		//Se agregan los objetos que se les desea cambiar el color
		for(var i = 0; i < numCajas.CompareTo(1); i++)
		{
			caja.GetComponent<Renderer>().material.color = colorCaja[UnityEngine.Random.Range(0,colorCaja.Length)];
		}
		for(var j = 0; j < numCajas.CompareTo(1); j++)
		{
			caja.transform.localScale = new Vector3(5,5,5);
		}
	}
}
