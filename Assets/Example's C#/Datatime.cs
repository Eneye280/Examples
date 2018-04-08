using System.Collections;
using UnityEngine;
using System;

public class Datatime : MonoBehaviour 
{
/*EL DATA TIME SE PODRIA UTILIZAR PARA HACER FUNCIONES EN LOS MOMENTOS INDICADOS(segundos,minutos,horas,dias,meses,año)*/
	private void Start () 
	{
/*FECHA Y HORA ACTUAL DEL SISTEMA */
		PlayerPrefs.SetString("date time",DateTime.Now.ToString("yyy/MM/dd HH:mm:ss"));
		print(PlayerPrefs.GetString("data time"));
		StartCoroutine(regalosDiarios());
	}
	private IEnumerator regalosDiarios()
	{
/*DATA TIME EN HORAS */
		if(DateTime.Now.Hour == 8)
		{
			print("Son las " + DateTime.Now.ToString("HH:mm:ss"));
			yield return new WaitForSeconds(1);
		}
/*DATA TIME EN DIA */
		if(DateTime.Now.Day == 12)
		{
			print("Es el dia " + DateTime.Now.ToString("dd"));
			yield return new WaitForSeconds(1);
		}
/*DATA TIME EN MES */
		if(DateTime.Now.Month == 2)
		{
			print("Es el mes " + DateTime.Now.ToString("MM"));
			yield return new WaitForSeconds(1);
		}
/*DATA TIME EN AÑOS */
		if(DateTime.Now.Year == 2018)
		{
			print("Es el año " + DateTime.Now.ToString("yyy"));
			yield return new WaitForSeconds(1);
		}

	}
}
