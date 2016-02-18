using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class CatController : MonoBehaviour
{
    public GameObject Pos1;
    public GameObject Pos2;
    public GameObject Pos3;
    public GameObject Pos4;

    [SerializeField]
    public float speed;
    [SerializeField]
    private GameObject[] TargetPos;
    [SerializeField]
    private Rigidbody ThisBody;
    [SerializeField]
    private int CurrentPos = 0;

    // Use this for initialization
    void Start()
    {
        ThisBody = GetComponent<Rigidbody>();
        TargetPos = new GameObject[] { Pos1, Pos2, Pos3, Pos4};
        Debug.Log(TargetPos.Length);
    }

    // Update is called once per frame
    void Update()
    {
        CatMovement(speed);
    }

    void CatMovement(float Cat_Speed)
    {

        if (ThisBody.transform.position != TargetPos[CurrentPos].transform.position)
        {
            //X
            if(ThisBody.transform.position.x <= TargetPos[CurrentPos].transform.position.x)
            {
                ThisBody.velocity = new Vector3(Cat_Speed, ThisBody.velocity.y, ThisBody.velocity.z);
            }
            else if(ThisBody.transform.position.x >= TargetPos[CurrentPos].transform.position.x)
            {
                ThisBody.velocity = new Vector3(-Cat_Speed, ThisBody.velocity.y, ThisBody.velocity.z);
            }
            //Z
            if (ThisBody.transform.position.z <= TargetPos[CurrentPos].transform.position.z)
            {
                ThisBody.velocity = new Vector3(ThisBody.velocity.x, ThisBody.velocity.y, Cat_Speed);
            }
            else if (ThisBody.transform.position.z >= TargetPos[CurrentPos].transform.position.z)
            {
                ThisBody.velocity = new Vector3(ThisBody.velocity.x, ThisBody.velocity.y, -Cat_Speed);
            }
        }

        if ((ThisBody.transform.position.x >= TargetPos[CurrentPos].transform.position.x - 0.5 && ThisBody.transform.position.x <= TargetPos[CurrentPos].transform.position.x + 0.5) &&
            (ThisBody.transform.position.z >= TargetPos[CurrentPos].transform.position.z - 0.5 && ThisBody.transform.position.z <= TargetPos[CurrentPos].transform.position.z + 0.5))
        {
            Debug.Log("Position hit");
            CurrentPos++;
        }


        if(CurrentPos >= TargetPos.Length)
        {
            CurrentPos = 0;
        }
    }
}
