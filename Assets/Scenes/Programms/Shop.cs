using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint StandardTurret;
    public TurretBlueprint Throwing_guy;
    BuildManager buildManager;
    int itemSelected = 0;

    void Start()
    {
        buildManager = BuildManager.instance;
        
    }
    public void SelectStandartTurret ()
    {
        if(itemSelected == 0 || itemSelected == 2)
        {
            Debug.Log("Standard Turret Selected");
            buildManager.SelectTurretToBuild(StandardTurret);
            itemSelected = 1;
        } else
        {
            buildManager.SelectTurretToBuild(null);
            itemSelected = 0;
        }
        
    }

    public void SelectThrowing_guy()
    {
        if (itemSelected == 0 || itemSelected == 1)
        {
            Debug.Log("Throwing_guy Selected");
            buildManager.SelectTurretToBuild(Throwing_guy);
            itemSelected = 2;
        }
        else
        {
            buildManager.SelectTurretToBuild(null);
            itemSelected = 0;
        }
    }
}
