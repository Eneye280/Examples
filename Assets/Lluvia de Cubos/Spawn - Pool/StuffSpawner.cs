using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffSpawner : MonoBehaviour 
{
	public Material stuffMaterial;
	public float 	timeBetweenSpwans;
	public Stuff[] 	stuffPrefabs;
	public FloatRange timeBspwans,scale,randomVelocity,angularVelocity;
	private float 	timeSinceLatSpawn;
	private float 	currentSpawnDelay;
	public float 	velocity;

	private void FixedUpdate()
	{
		timeSinceLatSpawn += Time.deltaTime;
		if(timeSinceLatSpawn >= currentSpawnDelay)
		{
			timeSinceLatSpawn -= currentSpawnDelay;
			currentSpawnDelay = timeBspwans.RandomInRange;
			SpawnStuff();
		}
	}

	private void SpawnStuff()
	{
		Stuff prefab = stuffPrefabs[Random.Range(0,stuffPrefabs.Length)];
		Stuff spawn = prefab.GetPooledInstantiate<Stuff>();
		spawn.transform.localPosition = transform.position;
		spawn.transform.localScale = Vector3.one * scale.RandomInRange;
		spawn.transform.localRotation = Random.rotation;
		spawn.Body.velocity = transform.up * velocity +
			Random.onUnitSphere * randomVelocity.RandomInRange;
		spawn.Body.angularVelocity = Random.onUnitSphere * angularVelocity.RandomInRange;
		spawn.GetComponent<MeshRenderer>().material = stuffMaterial;
		spawn.SetMaterial(stuffMaterial);
	}

}
