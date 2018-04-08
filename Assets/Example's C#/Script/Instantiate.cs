using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour 
{
	[SerializeField] int numBox;
	[SerializeField] GameObject CBox;
	[HideInInspector] GameObject cubo;

	private void Start()
	{
		InstantiateBox();
	}
	private void InstantiateBox()
	{
		for(int i = 0; i < numBox; i++)
		{
			for(int j = 0; j < numBox; j++ )
			{
				Vector3 posicion = new Vector3(j,i,0);
				cubo = Instantiate(CBox,posicion,Quaternion.identity);
			}
		}
	}
}
