using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinDisplay : MonoBehaviour
{
    public Skins skin;

    public Text nameText;

    public Image sprite;

    public Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = skin.name;
        sprite.sprite = skin.artWork;

        rigidBody.gravityScale = skin.gravityEffect;
        rigidBody.mass = skin.weight;

    }

}
