using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankSpawner : MonoBehaviour
{
    public tankView TankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void CreateTank()
    {
        tankModel TankModel = new tankModel(30,20);
        tankController tankController = new tankController(TankModel,TankView);
    }
}
