using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CustomizationMenu : MenuController
{
    [SerializeField]
    private Button skinsBtn, upgradesBtn;

    private static Color ACTIVE_COLOR = new Color(42, 42, 42, 42);
    private static Color INACTIVE_COLOR = new Color(255, 0, 0, 80);


    GameObject globalManager;


    private new enum PANEL_NAME
    {
        SKINS = 0,
        UPGRADES = 1
    };

    private void Start()
    {
        globalManager = GlobalManager.Instance.gameObject;
        InitializePanels();
        skinsBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.SKINS));
        upgradesBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.UPGRADES));
    }

    public void EnableSkins()
    {
        ChangeMenu(panels[(int)PANEL_NAME.UPGRADES], panels[(int)PANEL_NAME.SKINS]);
        this.SetActive(skinsBtn);
        this.SetInactive(upgradesBtn);
    }

    public void EnableUpgrades()
    {
        ChangeMenu(panels[(int)PANEL_NAME.SKINS], panels[(int)PANEL_NAME.UPGRADES]);
        this.SetActive(upgradesBtn);
        this.SetInactive(skinsBtn);
    }

    protected override void OnClickEvent(MENU_ACTION.ACTION mA)
    {
        switch (mA)
        {
            case MENU_ACTION.ACTION.SKINS:
                Debug.Log("Skins button pressed");
                EnableSkins();
                break;
            case MENU_ACTION.ACTION.UPGRADES:
                Debug.Log("Upgrades button pressed");
                EnableUpgrades();
                break;
            default:
                break;
        }
    }

    private void SetActive(Button btn)
    {
        Image btnImage = btn.GetComponent<Image>();
        btnImage.color = ACTIVE_COLOR;
    }

    private void SetInactive(Button btn)
    {
        Image btnImage = btn.GetComponent<Image>();
        btnImage.color = INACTIVE_COLOR;
    }
}
