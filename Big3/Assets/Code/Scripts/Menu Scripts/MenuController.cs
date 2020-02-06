using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class MenuController : MonoBehaviour
{
    public enum PANEL_NAME {};

    protected List<GameObject> panels;

    protected abstract void OnClickEvent(MENU_ACTION.ACTION mA);

    protected void InitializePanels()
    {
        panels = this.gameObject.GetComponent<PANEL_HOLDER>().GetPanel();
    }

    protected void ChangeMenu(GameObject currPanel, GameObject tarPanel)
    {
        if (currPanel!= null && tarPanel != null)
        {
            ActivateObj(tarPanel);
            DeactivateObj(currPanel);
        }
    }

    private void ActivateObj(GameObject obj)
    {
        obj.SetActive(true);
    }

    private void DeactivateObj(GameObject obj)
    {
        obj.SetActive(false);
    }
}

