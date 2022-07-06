using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankView : MonoBehaviour
{
    private tankController TankController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTankController(tankController _TankController)
    {
        TankController = _TankController;
    }
}
