using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkRandom : MonoBehaviour 
{
	[SerializeField] private float Velocidad;
	[SerializeField] private Transform[] puntosDePatrullaje;
	private int IndexActual;
	private Vector3 PuntoA;
	private Vector3 PuntoB;
	private float tiempoParaInciar;
	private float tiempoDeMovimiento;

	private void Awake()
	{
		tiempoParaInciar = 1;
		CalcularValores();
	}

	private void Update()
	{
		tiempoParaInciar += tiempoDeMovimiento * Time.deltaTime;

		if (tiempoParaInciar >= 1)
		{
			IndexActual++;

			if(IndexActual == puntosDePatrullaje.Length - 1)
			{
				IndexActual = 0;
			}
			CalcularValores();	
		}
		transform.position = Vector3.Lerp(PuntoA, PuntoB, tiempoParaInciar);
	}

	private void CalcularValores()
	{
		PuntoA = puntosDePatrullaje[IndexActual].position;
		PuntoB = puntosDePatrullaje[IndexActual + 1].position;

		tiempoParaInciar = 1 - tiempoParaInciar;
		tiempoDeMovimiento = 1 / Vector3.Distance(PuntoA, PuntoB) * Velocidad;
	}
}
