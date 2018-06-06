using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// attaches this components to the game objects that has this script
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]


public class FlexibleUIBotton : FlexibleUI {


    public enum ButtonType
    {
        Default,
        Confirm,
        Decline,
        Warning
    }


    // Instances of the image and button
    Image image;
    Image icon;
    Button button;

    public ButtonType buttonType;


    protected override void OnSkinUI()
    {
        base.OnSkinUI();

        // references to components
        image = GetComponent<Image>(); // getting the component attached in the game object
        button = GetComponent<Button>();
        icon = transform.Find("Icon").GetComponent<Image>();


        button.transition = Selectable.Transition.SpriteSwap;
        button.targetGraphic = image;



        image.sprite = skinData.buttonSprite; // this I guess that will not matter very much??? At least the color
        // nope, it matters. It sort of gets combined with the color chosen later on... so it's better to set this to none in the editor
        // or just forget about setting the sprite I guess, since we'll just set a color later...
        // or a transparent shape... or whatever that does not bother too much...

        image.type = Image.Type.Sliced;
        button.spriteState = skinData.buttonSpriteState;


        // icon image is overwritten on top of the one in the editor, apparently
        switch(buttonType)
        {
            case ButtonType.Default:
                image.color = skinData.defaultColor;
                icon.sprite = skinData.defaultSprite;
                break;
            case ButtonType.Confirm:
                image.color = skinData.confirmColor;
                icon.sprite = skinData.confirmSprite;
                break;
            case ButtonType.Decline:
                image.color = skinData.declineColor;
                icon.sprite = skinData.declineSprite;
                break;
            case ButtonType.Warning:
                image.color = skinData.warningColor;
                icon.sprite = skinData.warningSprite;
                break;
        }
    }


}
