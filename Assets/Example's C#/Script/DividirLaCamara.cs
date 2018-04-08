using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DividirLaCamara : MonoBehaviour
{
    Camera camara;
    public Vector4 posicionCamara;
/*Dividir la camara para crear un videojuego */
    void Update()
    {
        camara = GetComponent<Camera>();
        camara.rect = new Rect(posicionCamara.x, posicionCamara.y, posicionCamara.z, posicionCamara.w);
    }

/*  En inspector se crean las camaras necesarias (En este ejemplo se verifica con 4 y 2 camaras)

    * 4 camaras

    CAMARA SUPERIOR IZQUIERDA (X = 0, Y = 0.5 ,Z = 0.5 , W = 0.5)
    CAMARA INFERIOR IZQUIERDA (X = 0 ,Y = 0, Z = 0.5 , W = 0.5)

    CAMARA SUPERIOR DERECHA (X = 0.5, Y = 0.5, Z = 1, W = 0.5)
    CAMARA INFERIOR IZQUIERDA (X = 0.5, Y = 0, Z = 0.5, W = 0.5) 

    * 2 camaras
        Vertical
    CAMARA IZQUIERDA (X = 0, Y = 0, Z = 0.5, W = 1)
    CAMARA DERECHA (X = 0, Y = 0, Z = 1, W = 1)

        Horizontal
    CAMARA ARRIBA (X = 0, Y = 0, Z = 1, W = 1)
    CAMARA ABAJO (X = 0,Y = 0, Z = 1, W = 0.5)
*/
}
