using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankView : MonoBehaviour
{
    private tankController TankController;

    private float movement;
    private float rotation;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0,3f,-4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(movement!=0)
        {
            TankController.Move(movement,TankController.GetTankModel().movement);
        }

        if(rotation!=0)
        {
            TankController.rotate(rotation,TankController.GetTankModel().rotation);
        }
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(tankController _TankController)
    {
        TankController = _TankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }


}
