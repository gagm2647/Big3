using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MenuController
{
    public new enum PANEL_NAME
    {
        MAIN = 0,
        SETTINGS = 1
    };

    [SerializeField]
    private Button startBtn, settingsBtn;
    [SerializeField]
    private TMP_Text companyName, mainTitle;

    private GameObject globalManager;

    private void Start()
    {
        globalManager = GlobalManager.Instance.gameObject;
        InitializePanels();
        startBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.START));
        settingsBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.SETTINGS));
    }

    override protected void OnClickEvent(MENU_ACTION.ACTION mA)
    { 
        switch (mA)
        {
            case MENU_ACTION.ACTION.START:
                Debug.Log("Start button pressed");
                StartGame();
                break;
            case MENU_ACTION.ACTION.SETTINGS:
                Debug.Log("Settings button pressed");
                ChangeMenu(panels[(int)PANEL_NAME.MAIN], panels[(int)PANEL_NAME.SETTINGS]);
                break;
            case MENU_ACTION.ACTION.QUIT:
                break;
            default:
                break;
        }
    }

    private void StartGame()
    {
        globalManager.GetComponent<SceneManagement>().LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
