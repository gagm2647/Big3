using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MenuController
{
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private TMP_Text settingsTitle;

    // Start is called before the first frame update
    void Start()
    {
        InitializePanels();
    }

    override protected void OnClickEvent(MENU_ACTION.ACTION mA)
    {
        switch (mA)
        {
            case MENU_ACTION.ACTION.BACK:
                Debug.Log("Going back to the main menu");
                break;
            default:
                break;
        }
    }

    private void OpenMainMenu()
    {
        if (panels[(int)PANEL_NAME.MAIN] != null && panels[(int)PANEL_NAME.SETTINGS] != null)
        {
            ChangeMenu(panels[(int)PANEL_NAME.SETTINGS], panels[(int)PANEL_NAME.MAIN]);
        }
    }
}
