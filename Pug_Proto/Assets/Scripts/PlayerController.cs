using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{ 
    [HideInInspector]
    public float Speed = 1;
    [SerializeField]
    private Rigidbody ThisBody;

    // Use this for initialization
    void Start()
    {
        ThisBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls(Speed);
    }

    void PlayerControls(float player_speed)
    {
        if (Input.GetKey(KeyCode.W))
        {
            ThisBody.transform.Translate(new Vector3(0, 0, Speed/4));
        }

        if (Input.GetKey(KeyCode.A))
        {
            ThisBody.transform.Rotate(new Vector3(0, -Speed*2, 0));
        }

        if(Input.GetKey(KeyCode.S))
        {
            ThisBody.transform.Translate(new Vector3(0, 0, -Speed/4));
        }

        if(Input.GetKey(KeyCode.D))
        {
            ThisBody.transform.Rotate(new Vector3(0, Speed*2, 0));
        }

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }

    void Respawn()
    {
        Vector3 spawn = new Vector3(0, 0, 0);
        ThisBody.transform.position = spawn;


    }
    void OnCollisionEnter(Collision thing)
    {
        if (thing.gameObject.tag=="Enemy")
        {
            Respawn();
        }


    }
}
