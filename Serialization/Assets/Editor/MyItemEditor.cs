﻿// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEditor;

// [CustomEditor(typeof(MyItem))]
// public class MyItemEditor : Editor
// {
// 	private SerializedProperty idProperty;
// 	private SerializedProperty nameProperty;

// 	private void OnEnable() 
// 	{
// 		idProperty = serializedObject.FindProperty("id");
// 		nameProperty = serializedObject.FindProperty("name");
// 	}

// 	public override void OnInspectorGUI()
// 	{
// 		serializedObject.Update();

// 		EditorGUILayout.PropertyField(idProperty);
// 		EditorGUILayout.PropertyField(nameProperty);

// 		serializedObject.ApplyModifiedProperties();
// 	}
// }
