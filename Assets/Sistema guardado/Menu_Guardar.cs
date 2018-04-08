using UnityEngine;
using System.Collections;

public class Menu_Guardar : MonoBehaviour 
{
	public Vector3 PosPlayer;

	private GUISkin MySkin;

	private void Start () 
	{
		MySkin = Resources.Load<GUISkin>("MyGUISKIN");
	}
	private void Update () 
	{
		PosPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;
	}
	private void OnGUI()
	{
		GUI.skin = MySkin;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity,new Vector3(Screen.width / 800.0f, Screen.height / 600.0f, 1));
		GUI.Label(new Rect(0,0,450,200),"Posicion: " + PosPlayer);

		if(GUI.Button(new Rect(0,500,200,100),"Guardar"))
		{
			SysGuardar.Guardar_Posicion(PosPlayer);
		}
		if(GUI.Button(new Rect(200,500,200,100),"Cargar"))
		{
			GameObject.FindGameObjectWithTag("Player").transform.position = SysGuardar.Cargar_Posicion();
		}
	}
}
