using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour 
{
	PoolObject prefab;
	List<PoolObject> availableObjects = new List<PoolObject>();

	public PoolObject GetObject()
	{
		PoolObject obj;
		int lasAvailableIndes = availableObjects.Count -1;
		if(lasAvailableIndes >= 0)
		{
			obj = availableObjects[lasAvailableIndes];
			availableObjects.RemoveAt(lasAvailableIndes);
			obj.gameObject.SetActive(true);
		}else
		{
			obj = Instantiate<PoolObject>(prefab);
			obj.transform.SetParent(transform,false);
			obj.pool = this; 
		}
		return obj;
	}
	public void AddObject(PoolObject obj)
	{
		obj.gameObject.SetActive(false);
		availableObjects.Add(obj);
	}
	public static ObjectPool GetPool(PoolObject prefab)
	{
		GameObject obj;
		ObjectPool pool;
		if(Application.isEditor)
		{
			obj = GameObject.Find(prefab.name + "Pool");
			if(obj)
			{
				pool = obj.GetComponent<ObjectPool>();
				if(pool)
				{
					return pool;
				}
			}
		}
		obj = new GameObject(prefab.name + "Pool");
		pool = obj.AddComponent<ObjectPool>();
		pool.prefab = prefab;
		return pool;
	}
}
