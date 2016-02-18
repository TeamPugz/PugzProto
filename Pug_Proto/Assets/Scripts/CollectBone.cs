using UnityEngine;
using System.Collections;

public class CollectBone : MonoBehaviour
{
    PlayerController player;
  

  

   

    
 
   




    void Start()
    {
        

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
