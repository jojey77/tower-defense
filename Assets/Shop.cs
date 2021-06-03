using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint StandardTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;
    BuildManager buildManager;
    int itemSelected = 0;

    void Start()
    {
        buildManager = BuildManager.instance;

    }
    public void SelectStandartTurret()
    {
        if (itemSelected == 0 || itemSelected == 2)
        {
            Debug.Log("Standard Turret Selected");
            buildManager.SelectTurretToBuild(StandardTurret);
            itemSelected = 1;
        }
        else
        {
            buildManager.SelectTurretToBuild(null);
            itemSelected = 0;
        }

    }

    public void SelectMissileLauncher()
    {
        if (itemSelected == 0 || itemSelected == 1)
        {
            Debug.Log("Missile Launcher Selected");
            buildManager.SelectTurretToBuild(missileLauncher);
            itemSelected = 2;
        }
        else
        {
            buildManager.SelectTurretToBuild(null);
            itemSelected = 0;
        }
    }



    public void SelectLaserBeamer()
    {
        if (itemSelected == 0 || itemSelected == 1)
        {
            Debug.Log("Laser Beamer Selected");
            buildManager.SelectTurretToBuild(laserBeamer);
            itemSelected = 2;
        }
        else
        {
            buildManager.SelectTurretToBuild(null);
            itemSelected = 0;
        }
    }

}
