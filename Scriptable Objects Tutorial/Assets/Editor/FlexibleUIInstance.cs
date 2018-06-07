using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// this script will contain a static method that will allow us to create scriptable objects
// from right clicking in the editor

public class FlexibleUIInstance : Editor {

    static GameObject clickedObject;

    private static GameObject Create(string objectName)
    {
        GameObject instance = Instantiate(Resources.Load<GameObject>(objectName));
        instance.name = objectName;

        clickedObject = UnityEditor.Selection.activeObject as GameObject;

        if (clickedObject != null)
        {
            instance.transform.SetParent(clickedObject.transform, false);
        }

        return instance;
    }


    [MenuItem("GameObject/Flexible UI/Button Scriptable Object", priority = 0)]
    public static void AddButton()
    {
        Create("Button_ScriptableObject");
    }


}
