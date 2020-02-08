using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinDisplay : MonoBehaviour
{
    public Skins skin;

    public Text nameText;

    public Image sprite;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = skin.name;
        sprite.sprite = skin.artWork;

    }

}
