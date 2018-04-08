using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Stuff : PoolObject 
{
	public Rigidbody Body {get; private set;}
	MeshRenderer[] meshRenderer;

	public void SetMaterial(Material m)
	{
		for (int i = 0; i < meshRenderer.Length; i++)
		{
			meshRenderer[i].material = m;
		}
	}

	private void Awake()
	{
		Body = GetComponent<Rigidbody>();
		meshRenderer = GetComponentsInChildren<MeshRenderer>();
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("KillZone"))
		{
			ReturnToPool();
		}
	}
}
