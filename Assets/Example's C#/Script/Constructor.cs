﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour 
{
	char letra;
	int letra2;

	public Constructor()
	{
		for (letra = 'a'; letra <= 'z'; letra++ )
		{
			print(letra);
		}
		for (int i = 0; i < letra2; i++)
		{
			print(i);
		}
	}

	private void Awake()
	{
		print("Awake");
	}
}
