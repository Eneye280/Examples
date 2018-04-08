using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public sealed class ZoomCamera : MonoBehaviour 
{
	Transform cameraTrans;
	public float zoomCam;
	void Update () 
	{
		cameraTrans = Camera.main.transform;
		cameraTrans.position = Vector3.zero;
		cameraTrans.eulerAngles = new Vector3(45f,0,0);
		float scroll = Input.GetAxis("Mouse ScrollWheel");
		cameraTrans.Translate(-Vector3.forward * zoomCam);
		zoomCam = scroll;
		if(zoomCam > 9)
		{
			zoomCam = 9;
		}
		else if(zoomCam < 1)
		{
			zoomCam = 1;
		}
	}
}
