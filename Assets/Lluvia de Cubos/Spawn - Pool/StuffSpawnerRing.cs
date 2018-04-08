using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffSpawnerRing : MonoBehaviour 
{
	public Material[] stuffMaterials;
	public int numberOfSpawners;
	public float radius, tilAngle;
	public StuffSpawner spawnerPrefabs;

	private void Awake()
	{
		for (int i = 0; i < numberOfSpawners; i++)
		{
			CreateSpawner(i);
		}
	}

	private void CreateSpawner(int index)
	{
		Transform rotater = new GameObject("Rotater").transform;
		rotater.SetParent(transform,false);
		rotater.localRotation = 
				Quaternion.Euler(0f,index * 360f/numberOfSpawners,0f);
		StuffSpawner spawner = Instantiate<StuffSpawner>(spawnerPrefabs);
		spawner.transform.SetParent(rotater,false);
		spawner.transform.localPosition = new Vector3(0f,0f,radius);
		spawner.transform.localRotation = Quaternion.Euler(tilAngle,0f,0f);
		spawner.stuffMaterial = stuffMaterials[index % stuffMaterials.Length];
	}
}
