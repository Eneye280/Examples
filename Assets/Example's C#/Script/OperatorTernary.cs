using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorTernary : MonoBehaviour
{
	[Header("Vida")]
	[Range (-10,20)] public int health = 10;
	[SerializeField] GameObject box;
	[SerializeField] Color[] ColorsBox;
	void Start()
		{
			health = UnityEngine.Random.Range(-10,20);
			string mensaje;
			mensaje = health > 0 ? "OPERATOR - El jugador esta vivo" : " OPERATOR - El jugador murio";
/*si la salud del jugador es mayor a cero entonces mandar msj de que esta vivo, sino mandar msj de que murio */
/*en vez de string se pueden usar int, float,gameobject, para realizar diferentes funciones */
			print(mensaje);

/*Hacer esto es lo mismo que hacer lo de arriba, funcionan de igual forma */
			if(health > 0)
			{
				print("EL jugador esta vivo");
			}
			else
			{
				print("El jugador murio");
			}
/*En pantalla se imprimiran los valores tanto del operador ternario como el del if(programacion estructurada) */
			Ensayo();

		}
		#region caminar
		void Ensayo()
		{
/*Implementando gameobject */
			int verifica = UnityEngine.Random.Range(0,10);
			string nombrebox;
			Vector3 Posicion = new Vector3 (5,5,5);
			Vector3 trans = new Vector3(10,10,10);

			nombrebox = verifica > 5 ? box.name = "Cubo Grande" : box.name = "Cubo Pequeño";
/*implementando Vectores */
			Posicion =  verifica > 5 ? box.transform.position = trans : box.transform.position.normalized;

/*Implementando matematicas */
			int A = 5 * 5;
			int B = 10 * (-45) % 25;
			int Suma1;
			int Suma2;
			int SumaTotal;
			int ResultadoSumaTotal = 50;

			Suma1 =  A != B ? A + B : A - B;
			SumaTotal = Suma1 + A - B;
//print(SumaTotal) /*Resultado 50*/;
			Suma2 = SumaTotal >= ResultadoSumaTotal ? ResultadoSumaTotal = SumaTotal : ResultadoSumaTotal = ResultadoSumaTotal + A;
			print(Suma2);
			
		}
		#endregion
/*Instanciarle un color a un objecto cuando se corre al iniciar el juego */
		// void Update()
		// {
		// 	box.GetComponent<Renderer>().material.color = ColorsBox[Random.Range(0,ColorsBox.Length)];
		// }
}
