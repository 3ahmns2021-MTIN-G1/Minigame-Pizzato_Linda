using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public Rigidbody r;
    public Vector3 jumpPower;
    public Vector3 rightPower;
    public Vector3 leftPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKeyDown(jump))
        {
            r.AddForce(jumpPower);
        }

        if (Input.GetKeyDown(right))
        {
            print("hi");
            r.AddForce(rightPower);
        }
    
        if (Input.GetKeyDown(left))
        {
            print("no");
            r.AddForce(leftPower);
        }
    }
}
