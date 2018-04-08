using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enum : MonoBehaviour 
{
/*PASAR UN ENUM A UN NUMERO ENTERO*/	
	private enum enumEnsayos 
	{
    	numInt1 = 0, numInt2 = 1, numInt3 = 2, numInt4 = 3
	}
/*PASAR UN ENUM A UN STRING */
	private enum EnumEnsayos
	{
		letraString1,letraString2
	}
/*Comparacion de Enum */
	private enum enumensayos
	{
		enumValor1 = 1, enumValor2 = 1
	}
	void Start () 
	{
/*CONVERTIR A ENTERO */
		enumEnsayos valor0 = enumEnsayos.numInt1;
		enumEnsayos numInt1 = enumEnsayos.numInt2;
		enumEnsayos numInt2 = enumEnsayos.numInt3;
		enumEnsayos numInt3 = enumEnsayos.numInt4;
		object val0 = Convert.ChangeType(valor0, valor0.GetTypeCode());
		object val1 = Convert.ChangeType(numInt1, numInt1.GetTypeCode());
		object val2 = Convert.ChangeType(numInt2, numInt2.GetTypeCode());
		object val3 = Convert.ChangeType(numInt3, numInt3.GetTypeCode());
		print(val0);
		print(val1);
		print(val2);
		print(val3);

/*CONVERTIR A STRING */
		EnumEnsayos letraString1 = EnumEnsayos.letraString1;
		EnumEnsayos letraString2 = EnumEnsayos.letraString2;
		object let = Convert.ToString(letraString1.ToString());
		object let2 = Convert.ToString(letraString2);
		print(let);
		print(let2);

/*COMPARACIONES DE ENUM */
		if(enumensayos.enumValor1.Equals(enumensayos.enumValor2))
		{
			print("Iguales");
		}
		else
		{
			print("Distintos");
		}
	 	Debug.Log(enumensayos.enumValor1.CompareTo(enumensayos.enumValor2));
	}

    internal static object Parse(Type tp, string v)
    {
        throw new NotImplementedException();
    }
}
