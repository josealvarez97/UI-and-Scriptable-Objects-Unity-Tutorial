using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// attaches this components to the game objects that has this script
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]


public class FlexibleUIBotton : FlexibleUI {


    // Instances of the image and button
    Image image;
    Button button;


    protected override void OnSkinUI()
    {
        base.OnSkinUI();

        image = GetComponent<Image>(); // getting the component attached in the game object
        button = GetComponent<Button>();



        button.transition = Selectable.Transition.SpriteSwap;
        button.targetGraphic = image;



        image.sprite = skinData.buttonSprite;
        image.type = Image.Type.Sliced;
        button.spriteState = skinData.buttonSpriteState;
    }


}
