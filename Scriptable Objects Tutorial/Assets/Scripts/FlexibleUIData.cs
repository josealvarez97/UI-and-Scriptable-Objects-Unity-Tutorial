using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI Data")]
// Allows to create instances of this class, as a file or something like it  
// an  "skin object" / scriptable object 


public class FlexibleUIData : ScriptableObject {

    public Sprite buttonSprite;
    public SpriteState buttonSpriteState;


    public Color defaultColor;
    public Sprite defaultSprite;

    public Color confirmColor;
    public Sprite confirmSprite;

    public Color declineColor;
    public Sprite declineSprite;

    public Color warningColor;
    public Sprite warningSprite;



}
