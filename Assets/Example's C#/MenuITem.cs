using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuITem : MonoBehaviour
{
	[MenuItem("MyMenu/Instancia")]
	[MenuItem("MyMenu/Rotation")]
	[MenuItem("MyMenu/Position")]

	static void instancia()
	{
		float numberRandom = Random.Range(0,5);
		for (int i = 0; i < 1; i++)
		{
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			cube.transform.position  = new Vector3(0,0,numberRandom);
		}
	}
}
