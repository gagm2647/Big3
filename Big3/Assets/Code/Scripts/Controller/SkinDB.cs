using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinDB : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _skinDB;

    public List<GameObject> getSkins()
    {
        return _skinDB;
    }
}
