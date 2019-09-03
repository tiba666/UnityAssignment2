using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCar : MonoBehaviour
{

    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnResetButtonClick()
    {
        car.transform.rotation = Quaternion.Euler(1f, 1f, car.transform.rotation.z);
    }
}
