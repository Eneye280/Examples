﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Line))]
public class LineInspector : Editor 
{

	private void OnSceneGUI()
	{
		Line line = target as Line;
		Transform handleTransform = line.transform;
		Quaternion handleRotation = handleTransform.rotation;
		Vector3 p1 = handleTransform.TransformPoint(line.p1);
		Vector3 p2 = handleTransform.TransformPoint(line.p2);

		Handles.color = Color.white;
		Handles.DrawLine(line.p1,line.p2);
		Handles.DoPositionHandle(p1, handleRotation);
		Handles.DoPositionHandle(p2, handleRotation);

		EditorGUI.BeginChangeCheck();
		p1 = Handles.DoPositionHandle(p1,handleRotation);
		if(EditorGUI.EndChangeCheck())
		{
			Undo.RecordObject(line, "Move Point");
			EditorUtility.SetDirty(line);
			line.p1 = handleTransform.InverseTransformPoint(p1);
		}
		EditorGUI.BeginChangeCheck();
		p2 = Handles.DoPositionHandle(p2,handleRotation);
		if(EditorGUI.EndChangeCheck())
		{
			Undo.RecordObject(line, "Move Point");
			EditorUtility.SetDirty(line);
			line.p2 = handleTransform.InverseTransformPoint(p2);
		}
	}

}
