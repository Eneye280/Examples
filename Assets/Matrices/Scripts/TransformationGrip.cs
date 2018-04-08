using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections.Generic;

public class TransformationGrip : MonoBehaviour 
{
	public Transform prefab;
	public Transform Player;
	public int gridResolution;
	public float positionPlayer;
	Transform[] grid;
	List<Transformation> transformation;
	Transform point;
	Vector3 coordinates;

	private void Awake()
	{
		grid = new Transform[gridResolution * gridResolution * gridResolution];

		for (int i = 0, z = 0; z  < gridResolution; z++)
		{
			for (int y = 0; y < gridResolution; y++)
			{
				for (int x = 0; x < gridResolution; x++, i++)
				{
					grid[i] = CreateGridPoint(x,y,z);
				}
			}
		}
		transformation = new List<Transformation>();
	}
	private void Start()
	{
		Transform player = Instantiate<Transform>(Player);
        player.GetComponent<Rigidbody>().useGravity = false;
		player.localPosition = point.localPosition + new Vector3(0,positionPlayer,0);
	}
	private void Update()
	{
		GetComponents<Transformation>(transformation);
		for (int i = 0, z = 0; z < gridResolution; z++)
		{
			for (int y = 0; y < gridResolution; y++)
			{
				for (int x = 0; x < gridResolution; x++, i++)
				{
					grid[i].localPosition = TransformPoint(x,y,z);
				}
			}
		}
	}
/*CREA LAS INSTANCIAS DE LOS CUBOS */
	private Transform CreateGridPoint(int x, int y, int z)
	{
		point = Instantiate<Transform>(prefab);
		//point.gameObject.AddComponent<Rigidbody>().useGravity = false;
		point.tag = "Player";
		point.transform.parent = this.transform;
		point.localPosition = GetCoordinates(x,y,z);
/*DAR UN COLOR DE GRADIEN A LAS INSTANCIAS */
		point.GetComponent<MeshRenderer>().material.color = new Color
			((float)x / gridResolution, (float)y / gridResolution, (float)z/gridResolution);
	
		return point;
	}
	private Vector3 GetCoordinates(int x, int y, int z)
	{
		return new Vector3(x - (gridResolution - 1)* 0.5f,y - (gridResolution -1) * 0.5f,z - (gridResolution - 1) * 0.5f);
	}
	private Vector3 TransformPoint(int x, int y, int z)
	{
		coordinates = GetCoordinates(x,y,z);
		for (int i = 0; i < transformation.Count; i++)
		{
			coordinates = transformation[i].Apply(coordinates);
		}
		return coordinates;
	}
}
