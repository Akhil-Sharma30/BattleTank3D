
using UnityEngine;

public class tankModel
{
    private tankController TankController;

     public float movement;
    public float rotation;
    public tankModel(float _movement,float _rotation)
    {
        movement = _movement;
        rotation = _rotation;
    }

    public void SetTankController(tankController _TankController)
    {
        TankController = _TankController;
    }
}
