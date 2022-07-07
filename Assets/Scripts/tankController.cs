
using UnityEngine;

public class tankController 
{
    private tankModel TankModel;
    private tankView TankView;
    private Rigidbody rb;

    public tankController(tankModel _tankModel, tankView _tankView)
    {
        TankModel = _tankModel;
        TankView = GameObject.Instantiate<tankView>(_tankView);
        rb = TankView.GetRigidbody();

        TankModel.SetTankController(this);
        TankView.SetTankController(this);
    }

    public void Move(float Movement, float MovementSpeed)
    {
        rb.velocity = TankView.transform.forward * Movement * MovementSpeed;
    }

    public void rotate (float Rotation,float RotationSpeed) 
    {
        Vector3 vector = new Vector3(0f,Rotation * RotationSpeed,0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public tankModel GetTankModel()
    {
        return TankModel;
    }
}
