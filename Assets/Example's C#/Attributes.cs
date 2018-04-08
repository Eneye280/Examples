using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attributes : MonoBehaviour 
{
	[Range(0,100)]
	public int speed;
	[Header("Numero")]
	[Space(5)]
	public int numero1;
	[TextArea]
	public string letra1;
	[Multiline]
	public string letra2;
}
