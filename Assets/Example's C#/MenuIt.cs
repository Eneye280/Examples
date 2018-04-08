using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuIt 
{

	[MenuItem("Martinez/Mi nuevo Menu %#&")]
	static void MinuevoMenu()
	{
		
	}
	[MenuItem("Murillo/Otro nuevo Menu %#&")]
	static void OtronuevoMenu()
	{
		Debug.Log("Cree una belleza de menu nuevo");
	}

}
