
using UnityEngine;

public class tankController 
{
    private tankModel TankModel;
    private tankView TankView;

    public tankController(tankModel _tankModel, tankView _tankView)
    {
        TankModel = _tankModel;
        TankView = _tankView;

        TankModel.SetTankController(this);
        TankView.SetTankController(this);

        GameObject.Instantiate(TankView.gameObject);
    }
}
