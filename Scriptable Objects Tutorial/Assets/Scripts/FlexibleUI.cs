using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode()] // so that we don't have to play the game everytime

public class FlexibleUI : MonoBehaviour {

    // Let's create a reference to the scriptable objects so that we can inherit some values
    // from it
    public FlexibleUIData skinData;

    protected virtual void OnSkinUI()
    {
        // apparently where the objects will get and set the values retrieved from the skin object
    }


    public virtual void Awake()
    {
        OnSkinUI();
    }

    public virtual void Update()
    {
        if (Application.isEditor)
        {
            OnSkinUI();
        }
    }

}
