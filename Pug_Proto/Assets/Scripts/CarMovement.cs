using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour
{
    [SerializeField]
    public float spawnX, spawnY, spawnZ;
    [SerializeField]
    public Vector3 carVelocity;

    Rigidbody car;

    void Start()
    {
        car = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        car.velocity = carVelocity;
        ResetCar();
    }

    void ResetCar()
    {
        if (car.transform.position.z >= 15)
        {
            //Debug.Log("working");
            Vector3 temp = new Vector3(spawnX, spawnY, spawnZ);
            car.transform.position = temp;
        }
    }
}
