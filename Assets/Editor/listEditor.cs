using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(listBehaviour))]
public class NewBehaviourScript : Editor
{
    int valueAdd;
    int valueRemove;
    public override void OnInspectorGUI()
    {
        listBehaviour tableBehaviour = target as listBehaviour;

        EditorGUILayout.LabelField("Add", EditorStyles.boldLabel);
        valueAdd = EditorGUILayout.IntField("Value", valueAdd);

        //Botão para adicionar elementos a lista
        if (GUILayout.Button("Add"))
        {
            tableBehaviour.AddToList(tableBehaviour.entryList.Count.ToString(), valueAdd);
        }

        int elementoPraRemover = -1;
        EditorGUILayout.LabelField("List", EditorStyles.boldLabel);
        for (int i = 1; i < tableBehaviour.entryList.Count; i++)
        {
            EditorGUILayout.FloatField("Elemento" + i, tableBehaviour.entryList[i].value);

            //Botão para o elemento da lista
            if (GUILayout.Button("Remove"))
            {
                elementoPraRemover = i;
            }
        }

        if( elementoPraRemover>=0 )
        {
            tableBehaviour.entryList.RemoveAt(elementoPraRemover);
        }
    }
}