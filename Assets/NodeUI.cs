using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;

    public Text upgradeCost;
    public Button upgradeButton;

    private Node target;


    public void SetTarget(Node t)
    {
        target = t;

        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            //upgradeButton.interactable = true;
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;

        }
        else
        {
            upgradeCost.text = "Fully Upgraded";
            //upgradeButton.interactable = false;

        }

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {

        if (!target.isUpgraded)
        {
            target.UpgradeTurret();
            upgradeCost.text = "Fully Upgraded";
        }
        else
        {
            upgradeCost.text = "Fully Upgraded";
            Debug.Log("fully upgraded");
        }
        //BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}
