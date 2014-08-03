using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    private float StartCameraP;
    private float EndCameraP;
    bool RFlag;     
    public int acsel = 3; //加速度
    public GameObject obj;
    SpriteScript sprit;




    // Use this for initialization
    void Start()
    {
        sprit = obj.GetComponent<SpriteScript>();
        RFlag = false;
        StartCameraP = transform.position.x;
        EndCameraP = StartCameraP + 90;
    }

    // Update is called once per frame
    void Update()
    {

        if (!RFlag)
        {
            if (Input.GetMouseButtonDown(0))
                transform.position = new Vector3(transform.position.x + acsel, transform.position.y, transform.position.z);

            if (EndCameraP <= transform.position.x)
            {
                sprit.NextSprit();
                EndCameraP -=  90;
                RFlag = true;
            }

        }
        else
        {
            if (Input.GetMouseButtonDown(0))
                transform.position = new Vector3(transform.position.x - acsel, transform.position.y, transform.position.z);

            if (EndCameraP >= transform.position.x)
            {
                sprit.NextSprit();
                EndCameraP +=  90;
                RFlag = false;
            }
        }

    }

   
    
}
