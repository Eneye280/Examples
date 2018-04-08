using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Descripcion de la clase
///<sumary>
/// Divide entre dos la resolucion actual que tiene la pantalla
/// con esto se obtiene un performance mucho mayor.
/// Es importante realizarlo cuando existan muchos objetos en pantalla,
/// y cuando se utiliza post-processing.
/// Solo funciona dentro de la GPU ya que le quita carga
/// para la realizacion de los procesos,
/// funciona con Android e IOS.
///</sumary>
#endregion
public class UpFrame : MonoBehaviour 
{
	#region OptimizarGPU
	private float factor = 0.5f;
	private void Start()
	{
		Screen.SetResolution(
			Mathf.CeilToInt(Screen.currentResolution.width * factor),
			Mathf.CeilToInt(Screen.currentResolution.height * factor),true);
	}
	#endregion
	#region FPS
	float deltaTime = 0.0f;
	float fps;
	private void Update()
	{
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
		fps = 1.0f / deltaTime;
		print(fps);
	}
	#endregion
	
}
