using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {
    Rigidbody car;

	void Start () {
        car = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
        car.velocity = new Vector3(-5,0,0);
        ResetCar();
	}

    void ResetCar()
    {
        if (car.transform.position.x<-15)
        {
            Debug.Log("working");
            Vector3 temp = new Vector3(15, car.transform.position.y, car.transform.position.z);
            car.transform.position = temp;
        }
    }
}
