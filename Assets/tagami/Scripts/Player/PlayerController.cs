using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject shootingGunObj;

    Rigidbody rigidbody;
    Vector3 velocityBuff;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shootingGunObj.GetComponent<IGun>().Fire();
        }

        velocityBuff = Vector3.zero;
        //移動
        if (Input.GetKey(KeyCode.W))
        {
            velocityBuff += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocityBuff -= transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocityBuff -= transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocityBuff += transform.right;
        }
        //Shift Boost
        if(Input.GetKey(KeyCode.LeftShift))
        {
            velocityBuff *= 2.0f;
        }

    }

    private void FixedUpdate()
    {
        rigidbody.velocity = velocityBuff;
    }
}
