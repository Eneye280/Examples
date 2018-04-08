using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour 
{
	public TransformationGrip transformationGrip;
	private Vector3 offSet;
	void Start () 
	{
		offSet = transform.position - transformationGrip.Player.transform.position;
	}
	void LateUpdate()
	{
		transform.position = transformationGrip.Player.transform.position + offSet;
	}

}
