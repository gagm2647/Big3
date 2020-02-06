using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PANEL_HOLDER : MonoBehaviour
{ 
    [SerializeField]
    private List<GameObject> panels;
    
    public List<GameObject> GetPanel()
    {
        return panels;
    }
}
