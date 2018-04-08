using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procedura2D : MonoBehaviour 
{
	public Transform[] blockCity;
	public float speedCity;
    public float positionCityNew;
	void Update()
	{
		for(int i = 0; i < blockCity.Length; i++)
            {
                blockCity[i].Translate(-Vector3.forward *speedCity * Time.deltaTime);

                if(blockCity[i].position.z < positionCityNew)
                {
                    Vector3 newPosicion = blockCity[i].position;
                    newPosicion.z = 40f;
                    blockCity[i].position = newPosicion;
                }
            }
	}
}
