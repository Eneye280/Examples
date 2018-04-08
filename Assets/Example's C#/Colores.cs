using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores : MonoBehaviour 
{
/*En este script se ensaya el cambio de color solo con pasar el mouse, al pasar 20 segundos el color cambiara
a un tono azul, igualmente cuando se cliquea la rotacion del cubo cambia(se puede modificar ya que es un random)
al pasar el mouse por encima del objeto el nombre en herarchy se cambia al nombre del color, para diferenciar el objeto*/
	Color ColorInicial = Color.black;
    Color ColorSecundario;
    public GameObject box;
	string nameBoxMouseEncima = "Box Red";
	string nameBoxAlPasarTiempo = "Box Blue";
	string nameInicial = "Box Black";
	Vector3 scaleBox = new Vector3(0.5f,0.5f,0.5f);
    void Start()
    {
        box.GetComponent<Renderer>().material.color = ColorInicial;
    }
	void Update()
	{
		Vector3 posicionCaja = new Vector3(16.5f,3.831051f,3.737455f);
		/*al dar clic derecho los cubos con escalas de 0.5 volveran a su escala normal */
		if(Input.GetButtonDown("Fire2") && box.transform.localScale == scaleBox)
		{
			box.transform.localScale = new Vector3(3,3,3);
			box.transform.Rotate(new Vector3(0,0,0));
		}
		if(box.transform.position == posicionCaja)
		{
			print("-----");
			Destroy(box);
		}

		ScaleColor();
	}
	/*Al pasar el puntero del mouse por encima */
    void OnMouseEnter()
    {
        box.GetComponent<Renderer>().material.color = ColorSecundario = Color.red;

/*si el tiempo es mayor a 20 se cambiara el tono de color */
        if(Time.time > 20)
        {
            box.GetComponent<Renderer>().material.color = Color.blue;
        }
		if(box.GetComponent<Renderer>().material.color != Color.blue)
		{
			box.name = nameBoxMouseEncima;
		}else{
			box.name = nameBoxAlPasarTiempo;
		}
    }
    void OnMouseExit()
    {
        box.GetComponent<Renderer>().material.color = ColorInicial;
		box.name = nameInicial;
    }
/*Al presionar click */
	public void OnMouseDown()
	{
		if(box.GetComponent<Renderer>().material.color != Color.blue || box.GetComponent<Renderer>().material.color != Color.black)
		{
			float x = 15;
			float y = 30;
			float z = 45;
			box.transform.Rotate(x,y,z);
/*OPERATOR TERNARY */
			string msj;
			msj = x == y && x == z && y == x && y == z && z == x && z == y ? "The rorate coinciden" : "Rotation different";
			box.transform.localScale = scaleBox;
		}
	}

	private void ScaleColor()
	{
		if(box.transform.localScale == scaleBox)
		{
			box.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
	/*enviar a la posicion de la camara */
	// void OnMouseDrag()
	// {
	// 	RaycastHit rpoint;
	// 	if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out rpoint,100))
	// 	{
	// 		box.transform.position = rpoint.point;
	// 	}
	// }
}
