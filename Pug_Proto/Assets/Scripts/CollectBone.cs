using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class CollectBone : MonoBehaviour
{
    PlayerController player;
  
    Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        player = GetComponent<PlayerController>();
       
    }


    void Update()
    {
        

    }

    void Speed()
    {
        player.Speed += 1f;
    }

    void OnCollisionEnter(Collision bone)
    {
        if (bone.gameObject.tag == "Bone")
        {
            Speed();
            Destroy(bone.gameObject);
           
        }
    }


}
