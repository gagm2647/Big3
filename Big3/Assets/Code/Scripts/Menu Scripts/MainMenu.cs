using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    enum MENU_ACTION { START, SETTINGS, UPGRADES, QUIT};
    [SerializeField]
    private Button startBtn, settingsBtn;
    [SerializeField]
    private TMP_Text companyName, mainTitle;
    [SerializeField]
    private GameObject mainPanel, settingsPanel;

    private void Start()
    {
        startBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.START));
        settingsBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.SETTINGS));

    }

    private void OnClickEvent(MENU_ACTION mA)
    {
        switch (mA)
        {
            case MENU_ACTION.START:
                Debug.Log("Start button pressed");
                StartGame();
                break;
            case MENU_ACTION.SETTINGS:
                Debug.Log("Settings button pressed");
                OpenSettingsMenu();
                break;
            case MENU_ACTION.UPGRADES:
                break;
            case MENU_ACTION.QUIT:
                break;
            default:
                break;
        }
    }

    private void StartGame()
    {

    }

    private void OpenSettingsMenu()
    {
        if (mainPanel != null && settingsPanel != null)
        {
            ChangeState(mainPanel);
            ChangeState(settingsPanel);
        }
    }

    private void ChangeState(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }
}
