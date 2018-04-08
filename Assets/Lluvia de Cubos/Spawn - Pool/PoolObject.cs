using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour 
{
	[System.NonSerialized]
	ObjectPool poolInstantiateForPrefab;
	public ObjectPool pool {get; set;}
	public void ReturnToPool()
	{
		if(pool)
		{
			pool.AddObject(this);
		}else
		{
			Destroy(gameObject);
		}
	}

	public T GetPooledInstantiate<T>() where T : PoolObject
	{
		if(!poolInstantiateForPrefab)
		{
			poolInstantiateForPrefab = ObjectPool.GetPool(this);
		}
		return(T)poolInstantiateForPrefab.GetObject();
	}
}
