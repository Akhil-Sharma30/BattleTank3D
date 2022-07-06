using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankSpawner : MonoBehaviour
{
    [SerializeField] GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Tank,transform.position,Quaternion.identity);
    }
}
