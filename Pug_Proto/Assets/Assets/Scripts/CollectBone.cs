using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class CollectFood : MonoBehaviour
{
  
    Rigidbody rb;
   // Move playerMovement;
    public float energy;
    float ballScale = .5f;
    float massIncrement = 0.01f;

    [SerializeField]        // lets you keep a member variable private, but exposed to the Inspector
    Material normalFace;
    [SerializeField]
    Material eatingFace;
    [SerializeField]
 
    MeshRenderer render;
    float nomnomTimer = 0.0f;




    void Start()
    {
        
        energy = 3;
        transform.localScale = new Vector3(ballScale, ballScale, ballScale) * energy;

        rb = GetComponent<Rigidbody>();
        render = GetComponent<MeshRenderer>();
        //playerMovement = GetComponent<Move>();
        rb.mass = energy * massIncrement;
    }


    void Update()
    {
        

    }
   
    
    
    void Speed()
    {
        
    }

    void OnCollisionEnter(Collision food)
    {
        if (food.gameObject.tag == "Food")
        {
            
            Destroy(food.gameObject);
           
        }
    }


}
