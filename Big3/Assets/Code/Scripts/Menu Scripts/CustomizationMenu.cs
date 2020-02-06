using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CustomizationMenu : MenuController
{
    [SerializeField]
    private Button skinsBtn, upgradesBtn, prevBtn, nextBtn;

    private static Color ACTIVE_COLOR = new Color(42, 42, 42, 42);
    private static Color INACTIVE_COLOR = new Color(255, 0, 0, 80);

    private GameObject globalManager;

    private SkinPage skinPage;

    private new enum PANEL_NAME
    {
        SKINS = 0,
        UPGRADES = 1,
    };

    private void Start()
    {
        globalManager = GlobalManager.Instance.gameObject;
        skinPage = this.gameObject.GetComponent<SkinPage>();
        InitializePanels();
        skinsBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.SKINS));
        upgradesBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.UPGRADES));
        prevBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.PREVIOUS));
        nextBtn.onClick.AddListener(() => OnClickEvent(MENU_ACTION.ACTION.NEXT));

        if (panels[(int)PANEL_NAME.SKINS].activeSelf)
        {
            SetActive(skinsBtn);
        }
        else if(panels[(int)PANEL_NAME.UPGRADES].activeSelf)
        {
            SetActive(upgradesBtn);
        }
    }

    private void EnableSkins()
    {
        ChangeMenu(panels[(int)PANEL_NAME.UPGRADES], panels[(int)PANEL_NAME.SKINS]);
        this.SetActive(skinsBtn);
        this.SetInactive(upgradesBtn);
        prevBtn.gameObject.SetActive(true);
        nextBtn.gameObject.SetActive(true);
    }

    private void EnableUpgrades()
    {
        ChangeMenu(panels[(int)PANEL_NAME.SKINS], panels[(int)PANEL_NAME.UPGRADES]);
        this.SetActive(upgradesBtn);
        this.SetInactive(skinsBtn);
        prevBtn.gameObject.SetActive(false);
        nextBtn.gameObject.SetActive(false);
    }

    private GameObject GetActivePanel(List<GameObject> panels)
    {
        foreach (GameObject panel in panels)
        {
            if (panel.activeSelf == true)
            {
                return panel;
            }
        }

        return null;
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
            case MENU_ACTION.ACTION.PREVIOUS:
                Debug.Log("Offsettings the view backwards");
                skinPage.ChangeActiveSkins(SkinPage.DIRECTION.BACKWARDS);
                break;
            case MENU_ACTION.ACTION.NEXT:
                Debug.Log("Offsettings the view forward");
                skinPage.ChangeActiveSkins(SkinPage.DIRECTION.FORWARD);
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
