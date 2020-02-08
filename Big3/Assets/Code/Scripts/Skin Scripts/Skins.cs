using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName= "New skin", menuName = "Skin")]
public class Skins : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artWork;

    public float kickPower;
    public float weight;
    public int totalSwing;
    public float powerEfficiency;
    public float gravityEffect;

}
