using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Win : MonoBehaviour {

    [SerializeField]
    Text winText;
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision owner)
    {
        if (owner.gameObject.tag == "Owner")
        {
            winText.enabled = true;
        }


    }
}
