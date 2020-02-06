using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    private static GlobalManager instance = null;

    public static GlobalManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if( instance != this && instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

    }
}
